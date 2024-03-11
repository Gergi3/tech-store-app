using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.Core.Models.Components;

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

	public async Task<IActionResult> Index()
	{
		List<CategoryDTO> categories = await this._categoryService.All();

		List<CategoryListItemViewModel> categoryItems = categories
			.Select(x => new CategoryListItemViewModel()
			{
				Count = x.Count,
				Id = x.Id,
				Name = x.Name,
			})
			.ToList();

		this.ViewBag.CategoryItems = categoryItems;

		this.ViewBag.BreadcrumbList = new List<BreadcrumbItemViewModel>()
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

		return this.View();
	}
}
