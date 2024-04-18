using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.HomeFeatureList;

public class HomeFeatureList : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync()
	{
		List<HomeFeatureItemViewModel> items = new List<HomeFeatureItemViewModel>() {
			new HomeFeatureItemViewModel()
			{
				Text = "Free shipping!",
				Title = "For your convinience"
			},
			new HomeFeatureItemViewModel()
			{
				Text = "Fast delivery!",
				Title = "To save your precious time"
			},
			new HomeFeatureItemViewModel()
			{
				Text = "24/7 Support",
				Title = "To help you at any time"
			},
			new HomeFeatureItemViewModel()
			{
				Text = "Cheap products",
				Title = "To save a dollar for later"
			}
		};

		return this.View(items);
	}
}
