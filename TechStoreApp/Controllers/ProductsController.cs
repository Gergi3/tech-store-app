
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Components.ProductList;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.ViewModels.Pages;
using static TechStoreApp.Common.QueryConstants.Product;

namespace TechStoreApp.Controllers;

[Authorize]
public class ProductsController : BaseController
{
	private readonly IUIService _uiService;

	public ProductsController(
		IUIService uiService)
	{
		this._uiService = uiService;
	}

	[HttpGet]
	[AllowAnonymous]
	public async Task<IActionResult> Details(string? slug)
	{
		var breadcrumb = await this._uiService.ConstructProductDetailsPageBreadcrumb(slug);

		var viewModel = new ProductDetailsPageViewModel()
		{
			Breadcrumb = breadcrumb,
			Slug = slug,
			CurrentUserId = this.CurrentUserId
		};

		return this.View(viewModel);
	}

	[HttpGet]
	[AllowAnonymous]
	public async Task<IActionResult> Index(
		string? categorySlug,
		int? fromPrice,
		int? toPrice,
		int page = DefaultFirstPage,
		int perPage = DefaultPerPage)
	{
		var query = new ProductQueryParamsDTO()
		{
			CategorySlug = categorySlug,
			Page = page,
			PerPage = perPage,
			FromPrice = fromPrice,
			ToPrice = toPrice,
			CurrentUserId = this.CurrentUserId
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
	public async Task<IActionResult> ProductList(
		string? categorySlug,
		decimal? fromPrice,
		decimal? toPrice,
		int perPage = DefaultPerPage,
		int page = DefaultFirstPage)
	{
		var query = new ProductQueryParamsDTO()
		{
			Page = page,
			PerPage = perPage,
			FromPrice = fromPrice,
			ToPrice = toPrice,
			CurrentUserId = this.CurrentUserId,
			CategorySlug = categorySlug
		};

		// TODO: FUTURE IDEA
		// Validate params and create guid validator 
		// Validator.ValidateObject(query, new ValidationContext(query));

		object parameters = new { query, layout = false };

		return this.ViewComponent(typeof(ProductList), parameters);
	}
}
