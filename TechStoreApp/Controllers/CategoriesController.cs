using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Components.CategoryList;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.ViewModels;
using static TechStoreApp.Common.QueryConstants.Category;

namespace TechStoreApp.Controllers;
public class CategoriesController : Controller
{
	private readonly IUIService _uiService;
	private readonly IMapper _mapper;

	public CategoriesController(IUIService uiService, IMapper mapper)
	{
		this._uiService = uiService;
		this._mapper = mapper;
	}

	[HttpGet]
	public IActionResult Index()
	{
		var breadcrumb = this._uiService.ConstructCategoriesPageBreadcrumb();

		var query = new CategoryQueryParamsDTO()
		{
			Skip = DefaultSkip,
			Take = DefaultTake
		};

		var viewModel = new CategoryIndexViewModel()
		{
			Breadcrumb = breadcrumb,
			Query = query
		};

		return this.View(viewModel);
	}

	[HttpPost]
	[EnableCors("AllowSpecificOrigins")]
	public ViewComponentResult CategoryList(int skip, int take)
	{
		var query = new CategoryQueryParamsDTO()
		{
			Skip = skip,
			Take = take
		};

		return this.ViewComponent(typeof(CategoryList), new { query, layout = false });
	}
}
