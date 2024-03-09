using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Controllers;

public class ProductsController : BaseController
{
	public IActionResult Index()
	{
		this.ViewBag.ProductItems = new List<ProductListItemViewModel>()
		{
			new ProductListItemViewModel()
			{
				Stars = 5,
				CategoryId = new Guid("e5b88296-1188-4854-bdcc-fa5260cfe46e"),
				CategoryName = "Category Name",
				Price = 10.36m,
				ProductId = new Guid("c877a290-b458-4dca-b173-b8a16d317ec5"),
				ProductName = "Product name of the phone gotta be long so i can test if long ones fit",
				Reviews = 23,
			},
			new ProductListItemViewModel()
			{
				Stars = 5,
				CategoryId = new Guid("e5b88296-1188-4854-bdcc-fa5260cfe46e"),
				CategoryName = "Category Name",
				Price = 10.36m,
				ProductId = new Guid("c877a290-b458-4dca-b173-b8a16d317ec5"),
				ProductName = "Product name of the phone gotta be long so i can test if long ones fit",
				Reviews = 23
			},
			new ProductListItemViewModel()
			{
				Stars = 5,
				CategoryId = new Guid("e5b88296-1188-4854-bdcc-fa5260cfe46e"),
				CategoryName = "Category Name",
				Price = 10.36m,
				ProductId = new Guid("c877a290-b458-4dca-b173-b8a16d317ec5"),
				ProductName = "Product name of the phone gotta be long so i can test if long ones fit"
			},
			new ProductListItemViewModel()
			{
				Stars = 5,
				CategoryId = new Guid("e5b88296-1188-4854-bdcc-fa5260cfe46e"),
				CategoryName = "Category Name",
				Price = 10.15m,
				ProductId = new Guid("c877a290-b458-4dca-b173-b8a16d317ec5"),
				ProductName = "Product name of the phone gotta be long so i can test if long ones fit",
				Reviews = 23
			}
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
				Name = "Products",
			}
		};

		return this.View();
	}
}
