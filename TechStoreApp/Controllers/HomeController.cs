using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Controllers;

public class HomeController : BaseController
{
	public IActionResult Index()
	{
		this.ViewBag.BannerSliderItems = new List<BannerSliderItemViewModel>
		{
			new BannerSliderItemViewModel() {
				Title = "asd",
				SecondaryText = "some text",
				Text = "wassup",
				ProductId = new Guid("3ac50854-ed5a-4260-a3c0-d009605be4e3")
			},
			new BannerSliderItemViewModel() {
				Title = "Banner 2",
				SecondaryText = "This is a lot of text for Banner 2 ",
				Text = ";sajdiolasjdlasdlksaljk",
				ProductId = new Guid("3ac50854-ed5a-4260-a3c0-d009605be4e3")
			}
		};

		this.ViewBag.HomeCategoryItems = new List<HomeCategoryItemViewModel>
		{
			new HomeCategoryItemViewModel()
			{
				Count = 1,
				Name = "Headphones",
				CategoryId = new Guid("1cbcbd7f-7951-4093-8cde-50eba1f68a5f")
			},
			new HomeCategoryItemViewModel()
			{
				Count = 2,
				Name = "Headphones",
				CategoryId = new Guid("1cbcbd7f-7951-4093-8cde-50eba1f68a5f")
			},
			new HomeCategoryItemViewModel()
			{
				Count = 100,
				Name = "Headphones",
				CategoryId = new Guid("1cbcbd7f-7951-4093-8cde-50eba1f68a5f")
			},
			new HomeCategoryItemViewModel()
			{
				Count = 60,
				Name = "Headphones",
				CategoryId = new Guid("1cbcbd7f-7951-4093-8cde-50eba1f68a5f")
			},
		};

		this.ViewBag.HomeFeatureItems = new List<HomeFeatureItemViewModel>() {
			new HomeFeatureItemViewModel()
			{
				Text = "Some cool stuff broo",
				Title = "Cool Feature 1"
			},
			new HomeFeatureItemViewModel()
			{
				Text = "Some cool stuff broo",
				Title = "Cool Feature 2"
			},
			new HomeFeatureItemViewModel()
			{
				Text = "Some cool stuff broo",
				Title = "Cool Feature 3"
			},
			new HomeFeatureItemViewModel()
			{
				Text = "Some cool stuff broo",
				Title = "Cool Feature 4"
			}
		};

		this.ViewBag.HomeProductItems = new List<HomeProductListItemViewModel>()
		{
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 5,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 4,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
			new HomeProductListItemViewModel()
			{
				CategoryId = new Guid("5a391625-8d57-4840-9c65-a3e07e543edd"),
				CategoryName = "Phone",
				Price = 23.33m,
				Reviews = 10,
				Stars = 2,
				ProductName = "nokiata bratcheto"
			},
		};

		return this.View();
	}
}
