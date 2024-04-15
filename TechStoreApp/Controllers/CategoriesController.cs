using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Components.CategoryList;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Params;
using TechStoreApp.Models.Pages;

namespace TechStoreApp.Controllers;

[Authorize]
public class CategoriesController : BaseController
{
	private readonly IUIService _uiService;

	public CategoriesController(
		IUIService uiService,
		IAccountService accountService)
		: base(accountService)
	{
		this._uiService = uiService;
	}

	[HttpGet]
	[AllowAnonymous]
	public IActionResult Index()
	{
		var breadcrumb = this._uiService.CreateCategoriesPageBreadcrumb();
		var query = new CategoryQueryParams();

		var viewModel = new CategoryIndexPageViewModel()
		{
			Breadcrumb = breadcrumb,
			Query = query
		};

		return this.View(viewModel);
	}

	[HttpPost]
	[EnableCors("AllowSpecificOrigins")]
	[AllowAnonymous]
	public IActionResult CategoryList(
		CategoryQueryParams query)
	{
		if (!this.ModelState.IsValid)
		{
			return this.BadRequest(this.ModelState);
		}

		Type vcType = typeof(CategoryList);
		object vcParameters = new
		{
			query,
			layout = false
		};

		return this.ViewComponent(vcType, vcParameters);
	}
}
