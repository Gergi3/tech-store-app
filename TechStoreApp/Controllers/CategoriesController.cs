using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Controllers;
public class CategoriesController : Controller
{
	public IActionResult Index()
	{
		this.ViewBag.CategoryItems = new List<CategoryListItemViewModel>()
		{
			new CategoryListItemViewModel() {
				Count = 76,
				Id = new Guid("97c23877-7059-41bd-8f7b-4ce3f6196be2"),
				Name = "Some Category"
			},
			new CategoryListItemViewModel() {
				Count = 76,
				Id = new Guid("97c23877-7059-41bd-8f7b-4ce3f6196be2"),
				Name = "Some Category"
			},
			new CategoryListItemViewModel() {
				Count = 76,
				Id = new Guid("97c23877-7059-41bd-8f7b-4ce3f6196be2"),
				Name = "Some Category"
			},
			new CategoryListItemViewModel() {
				Count = 76,
				Id = new Guid("97c23877-7059-41bd-8f7b-4ce3f6196be2"),
				Name = "Some Category"
			},
			new CategoryListItemViewModel() {
				Count = 76,
				Id = new Guid("97c23877-7059-41bd-8f7b-4ce3f6196be2"),
				Name = "Some Category"
			},
			new CategoryListItemViewModel() {
				Count = 76,
				Id = new Guid("97c23877-7059-41bd-8f7b-4ce3f6196be2"),
				Name = "Some Category"
			},
			new CategoryListItemViewModel() {
				Count = 76,
				Id = new Guid("97c23877-7059-41bd-8f7b-4ce3f6196be2"),
				Name = "Some Category"
			},
			new CategoryListItemViewModel() {
				Count = 76,
				Id = new Guid("97c23877-7059-41bd-8f7b-4ce3f6196be2"),
				Name = "Some Category"
			},
		};

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
