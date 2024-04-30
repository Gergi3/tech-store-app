using AutoMapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Mappers;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Core.Models.Params;
using TechStoreApp.Core.Services;
using TechStoreApp.Data;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Test;

[TestFixture]
public class ReviewServiceTests
{
	private TechStoreDbContext _context;
	private ReviewService _reviewService;

	private static List<Product> _products = new List<Product>
	{
		new Product { Id = Guid.NewGuid(), Name = "Product 1", Slug = "product-1", Price = 19.99m, ImageUrl = "https://example.com/product1.jpg" },
		new Product { Id = Guid.NewGuid(), Name = "Product 2", Slug = "product-2", Price = 29.99m, ImageUrl = "https://example.com/product2.jpg" },
		new Product { Id = Guid.NewGuid(), Name = "Product 3", Slug = "product-3", Price = 39.99m, ImageUrl = "https://example.com/product3.jpg" }
	};

	private static List<AppUser> _users = new List<AppUser>
	{
		new AppUser { Id = Guid.NewGuid(), UserName = "user1@example.com", Email = "user1@example.com" },
		new AppUser { Id = Guid.NewGuid(), UserName = "user2@example.com", Email = "user2@example.com" },
		new AppUser { Id = Guid.NewGuid(), UserName = "user3@example.com", Email = "user3@example.com" }
	};

	private static List<Review> _reviews = new List<Review>
	{
		new Review { Id = Guid.NewGuid(), UserId = _users[0].Id, User = _users[0], ProductsId = _products[0].Id, Product = _products[0], Stars = 5, Text = "Great product!" },
		new Review { Id = Guid.NewGuid(), UserId = _users[1].Id, User = _users[1], ProductsId = _products[1].Id, Product = _products[1], Stars = 4, Text = "Good quality!" },
		new Review { Id = Guid.NewGuid(), UserId = _users[2].Id, User = _users[2], ProductsId = _products[2].Id, Product = _products[2], Stars = 3, Text = "Okay product." }
	};

	private void SetupDb()
	{
		var connection = new SqliteConnection("Filename=:memory:");
		connection.Open();

		var options = new DbContextOptionsBuilder<TechStoreDbContext>()
			.UseSqlite(connection)
			.Options;

		this._context = new TechStoreDbContext(options);

		string sql = this._context
			.GetService<IMigrator>()
			.GenerateScript(toMigration: "20240418191157_InitDb");

		this._context.Database.ExecuteSqlRaw(sql.Replace("varchar(max)", "varchar(255)"));
	}

	private IMapper CreateReviewMapper()
	{
		var profile = new ReviewProfile();
		var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
		IMapper mapper = new Mapper(configuration);

		return mapper;
	}

	[SetUp]
	public void Setup()
	{
		this.SetupDb();

		this._context.Products.AddRange(_products);
		this._context.Users.AddRange(_users);
		this._context.Reviews.AddRange(_reviews);
		this._context.SaveChanges();

		var mapper = this.CreateReviewMapper();

		this._reviewService = new ReviewService(
			repo: new Repository(this._context),
			mapper: mapper);
	}

	[Test]
	public async Task Exists_Returns_False_When_Review_Does_Not_Exist()
	{
		// Arrange
		var userId = Guid.NewGuid(); // User ID that does not exist in mock data
		var productId = Guid.NewGuid(); // Product ID that does not exist in mock data

		// Act
		var result = await this._reviewService.Exists(userId, productId);

		// Assert
		Assert.IsFalse(result);
	}

	[Test]
	public async Task Exists_Returns_True_For_Existing_Review()
	{
		// Arrange
		var existingReview = _reviews[0];

		// Act
		var result = await this._reviewService.Exists(existingReview.UserId, existingReview.ProductsId);

		// Assert
		Assert.IsTrue(result);
	}

	[Test]
	public async Task Exists_Returns_False_For_NonExisting_Review_With_Existing_User_Id()
	{
		// Arrange
		var existingUserId = _users[0].Id;
		var nonExistingProductId = Guid.NewGuid(); // Generating a non-existing product Id

		// Act
		var result = await this._reviewService.Exists(existingUserId, nonExistingProductId);

		// Assert
		Assert.IsFalse(result);
	}

	[Test]
	public async Task Exists_Returns_False_For_NonExisting_Review_With_Existing_Product_Id()
	{
		// Arrange
		var existingProductId = _products[0].Id;
		var nonExistingUserId = Guid.NewGuid(); // Generating a non-existing user Id

		// Act
		var result = await this._reviewService.Exists(nonExistingUserId, existingProductId);

		// Assert
		Assert.IsFalse(result);
	}

	[Test]
	public async Task Exists_Returns_False_For_NonExisting_Review_With_NonExisting_Ids()
	{
		// Arrange
		var nonExistingUserId = Guid.NewGuid(); // Generating a non-existing user Id
		var nonExistingProductId = Guid.NewGuid(); // Generating a non-existing product Id

		// Act
		var result = await this._reviewService.Exists(nonExistingUserId, nonExistingProductId);

		// Assert
		Assert.IsFalse(result);
	}

	[Test]
	public async Task Create_Returns_ReviewDTO_When_Review_Created_Successfully()
	{
		// Arrange
		var newReviewParams = new ReviewCreateParams
		{
			ProductsId = _products[1].Id,
			Stars = 5,
			Text = "Excellent product!"
		};
		var userId = _users[2].Id;

		// Act
		var result = await this._reviewService.Create(newReviewParams, userId);

		// Assert
		Assert.NotNull(result);
		Assert.IsInstanceOf<ReviewDTO>(result);
		Assert.That(result.Stars, Is.EqualTo(newReviewParams.Stars));
		Assert.That(result.Text, Is.EqualTo(newReviewParams.Text));
	}

	[Test]
	public async Task Create_Throws_UnexpectedUnauthenticatedUser_Exception_When_UserId_Is_Default()
	{
		// Arrange
		var newReviewParams = new ReviewCreateParams
		{
			ProductsId = _products[0].Id,
			Stars = 5,
			Text = "Excellent product!"
		};
		Guid userId = default; 

		// Act & Assert
		Assert.ThrowsAsync<UnexpectedUnauthenticatedUser>(
			async () => await this._reviewService.Create(newReviewParams, userId));
	}

	[Test]
	public async Task Create_Throws_Exception_When_ProductId_Is_Default()
	{
		// Arrange
		var newReviewParams = new ReviewCreateParams
		{
			ProductsId = default,
			Stars = 5,
			Text = "Excellent product!"
		};
		var userId = _users[0].Id;

		// Act & Assert
		Assert.ThrowsAsync<DbUpdateException>(
			async () => await this._reviewService.Create(newReviewParams, userId));
	}

	[TearDown]
	public void Dispose()
	{
		this._context.Database.EnsureDeleted();
		this._context.Dispose();
	}
}
