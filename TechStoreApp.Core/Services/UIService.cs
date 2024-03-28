using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Core.Services;
public class UIService : IUIService
{
	private readonly ICategoryService _categoryService;
	private readonly IProductService _productService;
	public UIService(ICategoryService categoryService, IProductService productService)
	{
		this._categoryService = categoryService;
		this._productService = productService;
	}

	public List<BreadcrumbItemViewModel> ConstructCategoriesPageBreadcrumb()
	{
		var breadcrumb = new List<BreadcrumbItemViewModel>()
		{
			new()
			{
				Name = "Home",
				Path = ("Home", "Index")
			},
			new()
			{
				Name = "Categories",
			}
		};

		return breadcrumb;
	}

	public async Task<List<BreadcrumbItemViewModel>> ConstructProductDetailsPageBreadcrumb(string slug)
	{
		List<BreadcrumbItemViewModel> breadcrumb = [
			new()
			{
				Name = "Home",
				Path = ("Home", "Index")
			},
			new()
			{
				Name = "Products",
				Path = ("Products", "Index")
			},
		];

		if (slug == null)
		{
			throw new SlugNullException();
		}

		var name = await this._productService.GetNameBySlug(slug);

		if (name == null)
		{
			throw new ProductNotFoundException();
		}

		breadcrumb.Add(new()
		{
			Name = name
		});

		return breadcrumb;
	}

	public async Task<List<BreadcrumbItemViewModel>> ConstructProductsPageBreadcrumb(
		ProductQueryParamsDTO query)
	{
		List<BreadcrumbItemViewModel> breadcrumb = [
			new()
			{
				Name = "Home",
				Path = ("Home", "Index")
			},
			new()
			{
				Name = "Products",
			},
		];

		string? categorySlug = query.CategorySlug;

		if (categorySlug != null)
		{
			string? dbName = await this._categoryService.GetNameBySlug(categorySlug);
			if (dbName == null)
			{
				throw new CategoryNotFoundException();
			}

			breadcrumb[^1].Path = ("Products", "Index");

			breadcrumb.Add(new()
			{
				Name = dbName
			});
		}

		return breadcrumb;
	}
}
