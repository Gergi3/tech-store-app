using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Components.CategoryList;
using TechStoreApp.Core.Contracts;
using TechStoreApp.ViewModels;

namespace TechStoreApp.Controllers;
public class CategoriesController : Controller
{
	private readonly ICategoryService _categoryService;
	private readonly IMapper _mapper;

	public CategoriesController(ICategoryService categoryService, IMapper mapper)
	{
		this._categoryService = categoryService;
		this._mapper = mapper;
	}

	[HttpGet]
	public async Task<IActionResult> Index()
	{
		var viewModel = new CategoryIndexViewModel();

		viewModel.Breadcrumb = [
			new()
			{
				Name = "Home",
				Path = ("Home", "Index")
			},
			new()
			{
				Name = "Categories",
			}
		];

		return this.View(viewModel);
	}

	[HttpPost]
	[EnableCors("AllowSpecificOrigins")]
	public ViewComponentResult CategoryList(int skip, int take)
	{
		return this.ViewComponent(typeof(CategoryList), new { skip, take, layout = false });
	}
}
