using TechStoreApp.Common.Exceptions;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Components;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.ViewModels.Components;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TechStoreApp.Services;
public class UIService : IUIService
{
	private readonly ICategoryService _categoryService;
	private readonly IProductService _productService;
	public UIService(
		ICategoryService categoryService,
		IProductService productService)
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
		if (slug == null)
		{
			throw new SlugNullException();
		}

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

		var name = await this._productService.GetNameBySlug(slug);

		if (name == null)
		{
			throw new UnexpectedNullProduct();
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
				throw new UnexpectedNullCategory();
			}

			breadcrumb[^1].Path = ("Products", "Index");

			breadcrumb.Add(new()
			{
				Name = dbName
			});
		}

		return breadcrumb;
	}

	public async Task<ProductPaginationViewModel> ConstructProductPagination(
		int page,
		int perPage,
		int totalCount)
	{
		int previousPage = page - 1;
		int nextPage = page + 1;
		int firstPage = 1;
		int lastPage = (totalCount + perPage - 1) / perPage;
		int showingFrom = page * perPage - perPage + 1;
		int showingTo = page * perPage;

		if (page == lastPage)
		{
			showingTo -= (page * perPage) - totalCount;
		}

		var pagination = new ProductPaginationViewModel()
		{
			Page = page,
			PerPage = perPage,
			TotalCount = totalCount,
			FirstPage = firstPage,
			LastPage = lastPage,
			NextPage = nextPage,
			PreviousPage = previousPage,
			ShowingFrom = showingFrom,
			ShowingTo = showingTo,
		};

		return pagination;
	}
}
