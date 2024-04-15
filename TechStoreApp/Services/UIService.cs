using TechStoreApp.Common.Exceptions;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Infrastructure.Data.EnumTypes;
using TechStoreApp.Models.Components;

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

	public List<BreadcrumbItemViewModel> CreateCategoriesPageBreadcrumb()
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

	public async Task<List<BreadcrumbItemViewModel>> CreateProductDetailsPageBreadcrumb(
		string slug)
	{
		if (slug == null)
		{
			throw new UnexpectedNullSlug();
		}

		var name = await this._productService.GetNameBySlug(slug);

		if (name == null)
		{
			throw new UnexpectedNullProduct();
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
			new()
			{
				Name = name
			}
		];

		return breadcrumb;
	}

	public async Task<List<BreadcrumbItemViewModel>> CreateShopPageBreadcrumb(
		string? categorySlug)
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

		if (categorySlug == null)
		{
			return breadcrumb;
		}

		string? name = await this._categoryService.GetNameBySlug(categorySlug);

		if (name == null)
		{
			throw new UnexpectedNullCategory();
		}

		breadcrumb[^1].Path = ("Products", "Index");

		breadcrumb.Add(new()
		{
			Name = name
		});

		return breadcrumb;
	}

	public ProductPaginationViewModel CreateProductPagination(
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

		if (totalCount == 0)
		{
			showingFrom = 0;
			showingTo = 0;
		}

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

	public List<BreadcrumbItemViewModel> CreateSessionBreadcrumb(SessionStatus status)
	{
		var breadcrumb = new List<BreadcrumbItemViewModel>()
		{
			new()
			{
				Name= "Home",
				Path = ("Home", "Index")
			},
			new()
			{
				Name = status == SessionStatus.Wishlisted ? "My Wishlist" : "My Cart"
			}
		};

		return breadcrumb;
	}
}
