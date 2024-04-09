
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Components.ProductList;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Models.Pages;

namespace TechStoreApp.Controllers;

[Authorize]
public class ProductsController : BaseController
{
	private readonly IUIService _uiService;
	private readonly IProductService _productService;
	private readonly ICategoryService _categoryService;

	public ProductsController(
		IUIService uiService,
		IProductService productService,
		ICategoryService categoryService)
	{
		this._uiService = uiService;
		this._productService = productService;
		this._categoryService = categoryService;
	}

	[HttpGet]
	[AllowAnonymous]
	public async Task<IActionResult> Details(
		string slug)
	{
		bool productExists = await this._productService.Exists(slug);
		if (!productExists)
		{
			return this.NotFound();
		}

		var breadcrumb = await this._uiService.CreateProductDetailsPageBreadcrumb(slug);

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
		ProductQueryParams query)
	{
		var validationResult = await this.ValidateQuery(query);
		if (validationResult.StatusCode != StatusCodes.Status200OK)
		{
			return validationResult;
		}

		var breadcrumb = await this._uiService.CreateShopPageBreadcrumb(query.CategorySlug);

		var viewModel = new ProductIndexPageViewModel()
		{
			Query = query,
			Breadcrumb = breadcrumb
		};

		return this.View(viewModel);
	}

	[HttpGet]
	[EnableCors("AllowSpecificOrigins")]
	[AllowAnonymous]
	public async Task<IActionResult> ProductList(
		ProductQueryParams query)
	{
		var validationResult = await this.ValidateQuery(query);
		if (validationResult.StatusCode != StatusCodes.Status200OK)
		{
			return validationResult;
		}

		Type vcType = typeof(ProductList);
		object vcParams = new
		{
			query,
			layout = false
		};

		return this.ViewComponent(vcType, vcParams);
	}

	[NonAction]
	public async Task<StatusCodeResult> ValidateQuery(ProductQueryParams query)
	{
		if (!this.ModelState.IsValid)
		{
			return this.BadRequest();
		}

		var categoryExists = await this._categoryService.TryExists(query.CategorySlug);
		if (!categoryExists)
		{
			return this.NotFound();
		}

		return this.Ok();
	}
}
