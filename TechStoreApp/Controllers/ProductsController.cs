using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.ViewModels;
using static TechStoreApp.Common.QueryConstants.Product;

namespace TechStoreApp.Controllers;

public class ProductsController : BaseController
{
	public IUIService _uiService { get; set; }
	public ProductsController(IUIService uiService)
	{
		this._uiService = uiService;
	}

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

		var viewModel = new ProductIndexViewModel()
		{
			Query = query,
			Breadcrumb = breadcrumb
		};

		return this.View(viewModel);
	}
}
