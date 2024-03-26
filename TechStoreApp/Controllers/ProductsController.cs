using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.ViewModels;

namespace TechStoreApp.Controllers;

public class ProductsController : BaseController
{
	public IProductService _productService { get; set; }
	public ProductsController(IProductService productService)
	{
		this._productService = productService;
	}

	public async Task<IActionResult> Index(string? categorySlug)
	{
		var viewModel = new ProductIndexViewModel();

		ProductQueryParamsDTO queryParams = new()
		{
			CategorySlug = categorySlug
		};

		viewModel.Breadcrumb = await this._productService.ConstructBreadcrumb(queryParams);
		viewModel.Query = queryParams;

		return this.View(viewModel);
	}
}
