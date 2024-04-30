using AutoMapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Mappers;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Core.Services;
using TechStoreApp.Data;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Test;

[TestFixture]
public class CategoryServiceTests
{
	private TechStoreDbContext _context;
	private CategoryService _categoryService;


	private List<Category> _data = new List<Category>() {
		new Category()
		{
			Id = new Guid("771aefc7-4538-4c6e-be2d-0def6fe0e8dd"),
			ImageUrl = "https://picsum.photos/200/300",
			Name = "Test Category 1",
			Slug = "test-category-1",
			Products = CreateProductListMock(2)
		},
		new Category()
		{
			Id = new Guid("9151e4ca-7c3d-4af3-9357-4eeffb1a1997"),
			ImageUrl = "https://picsum.photos/200/300",
			Name = "Test Category 2",
			Slug = "test-category-2",
			Products = CreateProductListMock(5)
		},
		new Category()
		{
			Id = new Guid("72469eee-a7f8-42ee-821b-597e222bd973"),
			ImageUrl = "https://picsum.photos/200/300",
			Name = "Test Category 3",
			Slug = "test-category-3",
			Products = CreateProductListMock(1)
		},
	};

	private static EntityList<Product> CreateProductListMock(int returns)
	{
		var list = new EntityList<Product>();

		for (int i = 0; i < returns; i++)
		{
			var product = new Product()
			{
				Id = Guid.NewGuid(),
				Name = $"Product Test Name {Guid.NewGuid()}",
				Slug = $"product-test-slug-{Guid.NewGuid()}",
				Price = 23,
				ImageUrl = "https://picsum.photos/200/300"
			};
			list.Add(product);
		}

		return list;
	}

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

	private IMapper CreateCategoryMapper()
	{
		var profile = new CategoryProfile();
		var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
		IMapper mapper = new Mapper(configuration);

		return mapper;
	}

	[SetUp]
	public void Setup()
	{
		this.SetupDb();

		this._context.Categories.AddRange(this._data);
		this._context.SaveChanges();

		var mapper = this.CreateCategoryMapper();

		this._categoryService = new CategoryService(
			repo: new Repository(this._context),
			mapper: mapper);
	}

	[Test]
	[TestCase(0, 3)]
	[TestCase(0, 5)]
	[TestCase(2, 3)]
	public async Task All_ReturnsCorrectNumberOfCategories(int skip, int take)
	{
		// Act
		var categories = await this._categoryService.All(skip, take);

		// Assert
		Assert.That(categories.Count, Is.EqualTo(Math.Min(take, this._data.Count - skip)));
	}

	[Test]
	[TestCase(0, 3)]
	[TestCase(0, 5)]
	[TestCase(2, 3)]
	public async Task All_ReturnsCorrectCategories(int skip, int take)
	{
		// Act
		var categories = await this._categoryService.All(skip, take);

		// Assert
		CollectionAssert.AllItemsAreInstancesOfType(categories, typeof(CategoryDTO));
	}

	[Test]
	[TestCase(7, 3)]
	[TestCase(10, 5)]
	[TestCase(100, 3)]
	public async Task All_ReturnsEmptyList_WhenSkipIsGreaterThanTotalCategories(int skip, int take)
	{
		// Act
		var categories = await this._categoryService.All(skip, take);

		// Assert
		Assert.IsEmpty(categories);
	}

	[Test]
	[TestCase(-1, 0)]
	[TestCase(0, -1)]
	[TestCase(-1, -1)]
	[TestCase(int.MinValue, 3)]
	[TestCase(3, int.MinValue)]
	[TestCase(int.MinValue, int.MinValue)]
	public async Task All_DoesNotThrowException_WhenNegativeParameters(int skip, int take)
	{
		// Act & Assert
		Assert.DoesNotThrowAsync(
			async () => await this._categoryService.All(skip, take));
	}

	[Test]
	[TestCase(3)]
	[TestCase(5)]
	[TestCase(10)]
	public async Task AllMostPopular_ReturnsCorrectNumberOfCategories(int take)
	{
		// Act
		var categories = await this._categoryService.AllMostPopular(take);

		// Assert
		Assert.That(categories.Count, Is.LessThanOrEqualTo(take));
	}

	[Test]
	[TestCase(3)]
	[TestCase(5)]
	[TestCase(10)]
	public async Task AllMostPopular_ReturnsCorrectCategories(int take)
	{
		// Act
		var categories = await this._categoryService.AllMostPopular(take);

		// Assert
		CollectionAssert.AllItemsAreInstancesOfType(categories, typeof(CategoryDTO));
	}

	[Test]
	public async Task AllMostPopular_ReturnsCategoriesOrderedByPopularity()
	{
		// Arrange
		var expectedOrder = this._data
			.OrderByDescending(c => c.Products.Count)
			.Select(c => c.Name)
			.ToList();

		// Act
		var categories = await this._categoryService.AllMostPopular(this._data.Count);

		// Assert
		Assert.That(categories.Count, Is.EqualTo(expectedOrder.Count));
		for (int i = 0; i < expectedOrder.Count; i++)
		{
			Assert.That(categories[i].Name, Is.EqualTo(expectedOrder[i]));
		}
	}

	[Test]
	public async Task Count_ReturnsTotalNumberOfCategories()
	{
		// Arrange
		var expectedCount = this._data.Count;

		// Act
		var count = await this._categoryService.Count();

		// Assert
		Assert.That(count, Is.EqualTo(expectedCount));
	}

	[Test]
	public async Task Count_ReturnsZero_WhenNoCategoriesExist()
	{
		// Arrange
		this._context.Categories.RemoveRange(this._context.Categories);
		await this._context.SaveChangesAsync();

		// Act
		var count = await this._categoryService.Count();

		// Assert
		Assert.That(count, Is.EqualTo(0));
	}

	[Test]
	public async Task Count_ReturnsCorrectNumberOfCategories_AfterAddingNewCategory()
	{
		// Arrange
		var newCategory = new Category
		{
			Id = Guid.NewGuid(),
			ImageUrl = "https://picsum.photos/200/300",
			Name = "New Category",
			Slug = "new-category"
		};

		this._context.Categories.Add(newCategory);
		await this._context.SaveChangesAsync();

		// Act
		var count = await this._categoryService.Count();

		// Assert
		Assert.That(count, Is.EqualTo(this._data.Count + 1));
	}

	[Test]
	[TestCase("test-category-1", true)]
	[TestCase("test-category-2", true)]
	[TestCase("test-category-3", true)]
	[TestCase("non-existing-slug", false)]
	public async Task TryExists_ReturnsTrue_WhenCategoryExists(string slug, bool expectedResult)
	{
		// Act
		var exists = await this._categoryService.TryExists(slug);

		// Assert
		Assert.That(exists, Is.EqualTo(expectedResult));
	}

	[Test]
	public async Task TryExists_ReturnsTrue_WhenSlugIsNull()
	{
		// Act
		var exists = await this._categoryService.TryExists(null);

		// Assert
		Assert.IsTrue(exists);
	}

	[Test]
	public async Task TryExists_ReturnsTrue_WhenSlugIsNullAndNoCategoriesExist()
	{
		// Arrange
		this._context.Categories.RemoveRange(this._context.Categories);
		this._context.SaveChanges();

		// Act
		var exists = await this._categoryService.TryExists(null);

		// Assert
		Assert.IsTrue(exists);
	}

	[Test]
	[TestCase("test-category-1", "Test Category 1")]
	[TestCase("test-category-2", "Test Category 2")]
	[TestCase("test-category-3", "Test Category 3")]
	[TestCase("non-existing-slug", null)]
	public async Task GetNameBySlug_ReturnsCorrectName(string slug, string expectedName)
	{
		// Act
		var name = await this._categoryService.GetNameBySlug(slug);

		// Assert
		Assert.That(name, Is.EqualTo(expectedName));
	}

	[Test]
	public async Task GetNameBySlug_ThrowsUnexpectedNullSlugException_WhenSlugIsNull()
	{
		// Act & Assert
		Assert.ThrowsAsync<UnexpectedNullSlug>(async () => await this._categoryService.GetNameBySlug(null));
	}

	[TearDown]
	public void Dispose()
	{
		this._context.Database.EnsureDeleted();
		this._context.Dispose();
	}
}
