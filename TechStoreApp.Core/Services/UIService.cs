using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Core.Services;
public class UIService : IUIService
{
	private readonly ICategoryService _categoryService;
	public UIService(ICategoryService categoryService)
	{
		this._categoryService = categoryService;
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
