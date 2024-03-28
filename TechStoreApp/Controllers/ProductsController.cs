using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Components.ProductList;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.ViewModels.Pages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static TechStoreApp.Common.QueryConstants.Product;

namespace TechStoreApp.Controllers;

public class ProductsController : BaseController
{
	private readonly IUIService _uiService;

	public ProductsController(IUIService uiService)
	{
		this._uiService = uiService;
	}

	[HttpGet]
	public async Task<IActionResult> Details(string slug)
	{
		var breadcrumb = await this._uiService.ConstructProductDetailsPageBreadcrumb(slug);

		var viewModel = new ProductDetailsPageViewModel()
		{
			Breadcrumb = breadcrumb,
			Slug = slug
		};

		return this.View(viewModel);
	}

	[HttpGet]
	public async Task<IActionResult> Index(
		string? categorySlug,
		int page = DefaultFirstPage,
		int perPage = DefaultPerPage)
	{
		var query = new ProductQueryParamsDTO()
		{
			CategorySlug = categorySlug,
			Page = page,
			PerPage = perPage
		};

		var breadcrumb = await this._uiService.ConstructProductsPageBreadcrumb(query);

		var viewModel = new ProductIndexPageViewModel()
		{
			Query = query,
			Breadcrumb = breadcrumb
		};

		return this.View(viewModel);
	}

	[HttpGet]
	[EnableCors("AllowSpecificOrigins")]
	public ViewComponentResult ProductList(int perPage, int page)
	{
		var query = new ProductQueryParamsDTO()
		{
			Page = page,
			PerPage = perPage
		};

		return this.ViewComponent(typeof(ProductList), new { query, layout = false });
	}
}
