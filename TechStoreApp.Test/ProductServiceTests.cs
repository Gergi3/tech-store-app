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
public class ProductServiceTests
{
	private TechStoreDbContext _context;
	private ProductService _productService;

	private static List<Product> _products = new List<Product>
	{
		new Product { Id = Guid.NewGuid(), Name = "Product 1", Slug = "product-1", Price = 19.99m, ImageUrl = "https://example.com/product1.jpg" },
		new Product { Id = Guid.NewGuid(), Name = "Product 2", Slug = "product-2", Price = 29.99m, ImageUrl = "https://example.com/product2.jpg" },
		new Product { Id = Guid.NewGuid(), Name = "Product 3", Slug = "product-3", Price = 39.99m, ImageUrl = "https://example.com/product3.jpg" }
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

	private IMapper CreateProductMapper()
	{
		var profile = new ProductProfile();
		var configuration = new MapperConfiguration(cfg => {

			cfg.AddProfile(profile);
			cfg.AddProfile(new CategoryProfile());
			cfg.AddProfile(new ExtraInfoProfile());
			cfg.AddProfile(new ReviewProfile());
		});
		IMapper mapper = new Mapper(configuration);

		return mapper;
	}

	[SetUp]
	public void Setup()
	{
		this.SetupDb();

		this._context.Products.AddRange(_products);
		this._context.SaveChanges();

		var mapper = this.CreateProductMapper();

		this._productService = new ProductService(
			repo: new Repository(this._context),
			mapper: mapper);
	}

	[Test]
	public async Task All_Returns_All_Products_When_No_Filters_Are_Applied()
	{
		// Act
		var result = await this._productService.All(new ProductQueryParams(), Guid.NewGuid());

		// Assert
		Assert.That(result.Count, Is.EqualTo(_products.Count));
	}

	[Test]
	public async Task All_Filters_By_Category_When_CategorySlug_Is_Provided()
	{
		// Arrange
		var categorySlug = "product-category"; // Assuming a valid category slug

		// Act
		var result = await this._productService.All(new ProductQueryParams { CategorySlug = categorySlug }, Guid.NewGuid());

		// Assert
		var productsInCategory = _products.Where(p => p.Categories.Any(c => c.Slug == categorySlug)).Count();
		Assert.That(result.Count, Is.EqualTo(productsInCategory));
	}

	[Test]
	public async Task All_Filters_By_Price_Range_When_FromPrice_And_ToPrice_Are_Provided()
	{
		// Arrange
		var fromPrice = 20.00m;
		var toPrice = 40.00m;

		// Act
		var result = await this._productService.All(new ProductQueryParams { FromPrice = fromPrice, ToPrice = toPrice }, Guid.NewGuid());

		// Assert
		var productsInPriceRange = _products.Where(p => p.Price >= fromPrice && p.Price <= toPrice).Count();
		Assert.That(result.Count, Is.EqualTo(productsInPriceRange));
	}

	[Test]
	public async Task All_Returns_Correct_Number_Of_Products_Per_Page()
	{
		// Arrange
		var page = 1;
		var perPage = 2;

		// Act
		var result = await this._productService.All(new ProductQueryParams { Page = page, PerPage = perPage }, Guid.NewGuid());

		// Assert
		Assert.That(result.Count, Is.EqualTo(perPage));
	}

	[Test]
	public async Task All_Returns_Empty_List_When_No_Products_Are_Available()
	{
		// Arrange
		_context.Products.RemoveRange(_context.Products);
		await _context.SaveChangesAsync();

		// Act
		var result = await this._productService.All(new ProductQueryParams(), Guid.NewGuid());

		// Assert
		Assert.IsEmpty(result);
	}

	[Test]
	public async Task GetBySlug_Returns_ProductDTO_When_Valid_Slug_Provided()
	{
		// Arrange
		var validSlug = "product-1"; // Assuming a valid product slug

		// Act
		var result = await this._productService.GetBySlug(validSlug);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(validSlug, result.Slug);
	}

	[Test]
	public async Task GetBySlug_Throws_Exception_When_Slug_Not_Found()
	{

		// Act & Assert
		Assert.ThrowsAsync<UnexpectedNullSlug>(async () =>
		{
			await this._productService.GetBySlug(null);
		});
	}

	[Test]
	public async Task GetNameBySlug_Returns_ProductName_When_Valid_Slug_Provided()
	{
		// Arrange
		var validSlug = "product-1"; // Assuming a valid product slug
		var expectedName = "Product 1"; // Assuming the expected name corresponding to the valid slug

		// Act
		var result = await this._productService.GetNameBySlug(validSlug);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(expectedName, result);
	}

	[Test]
	public async Task GetNameBySlug_Returns_Null_When_Null_Slug_Provided()
	{
		// Assert
		Assert.ThrowsAsync<UnexpectedNullSlug>(async () =>
		{
			await this._productService.GetNameBySlug(null);
		});
	}

	[Test]
	public async Task GetNameBySlug_Returns_Null_When_Slug_Not_Found()
	{
		// Arrange
		var invalidSlug = "invalid-slug"; // Assuming an invalid product slug

		// Act
		var result = await this._productService.GetNameBySlug(invalidSlug);

		// Assert
		Assert.IsNull(result);
	}

	[Test]
	public async Task Count_Returns_Correct_Number_Of_Products_When_Price_Range_Provided()
	{
		// Arrange
		var queryParams = new ProductQueryParams { FromPrice = 10, ToPrice = 30 }; // Assuming a price range
		var expectedCount = 2; // Assuming there are 2 products within the provided price range

		// Act
		var result = await this._productService.Count(queryParams);

		// Assert
		Assert.AreEqual(expectedCount, result);
	}

	[Test]
	public async Task Exists_Returns_True_When_Valid_Slug_Provided()
	{
		// Arrange
		var validSlug = "product-1"; // Assuming a valid product slug

		// Act
		var result = await this._productService.Exists(validSlug);

		// Assert
		Assert.IsTrue(result);
	}


	[Test]
	public async Task Exists_Returns_False_When_Invalid_Slug_Provided()
	{
		// Arrange
		var invalidSlug = "invalid-slug"; // Assuming an invalid product slug

		// Act
		var result = await this._productService.Exists(invalidSlug);

		// Assert
		Assert.IsFalse(result);
	}

	[TearDown]
	public void Dispose()
	{
		this._context.Database.EnsureDeleted();
		this._context.Dispose();
	}
}
