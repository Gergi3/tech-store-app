using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Components.CategoryList;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.ViewModels.Pages;
using static TechStoreApp.Common.QueryConstants.Category;

namespace TechStoreApp.Controllers;

[Authorize]
public class CategoriesController : BaseController
{
	private readonly IUIService _uiService;

	public CategoriesController(IUIService uiService)
	{
		this._uiService = uiService;
	}

	[HttpGet]
	[AllowAnonymous]
	public IActionResult Index()
	{
		var breadcrumb = this._uiService.ConstructCategoriesPageBreadcrumb();

		var query = new CategoryQueryParamsDTO()
		{
			Skip = DefaultSkip,
			Take = DefaultTake
		};

		var viewModel = new CategoryIndexPageViewModel()
		{
			Breadcrumb = breadcrumb,
			Query = query
		};

		return this.View(viewModel);
	}

	[HttpPost]
	[EnableCors("AllowSpecificOrigins")]
	public ViewComponentResult CategoryList(
		int skip = DefaultSkip,
		int take = DefaultTake)
	{
		var query = new CategoryQueryParamsDTO()
		{
			Skip = skip,
			Take = take
		};

		object parameters = new { query, layout = false };

		return this.ViewComponent(typeof(CategoryList), parameters);
	}
}
