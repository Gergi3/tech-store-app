using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.BannerSlider;

public class BannerSlider : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync()
	{
		List<BannerSliderItemViewModel> items = [
			new BannerSliderItemViewModel()
			{
				Title = "Tech Essentials",
				SecondaryText = "Discover Cutting-Edge Gadgets & Accessories",
				Text = "Upgrade Your Gear!",
				ImageUrl = "https://manofmany.com/wp-content/uploads/2021/01/Tech-Essentials.png"
			},
			new BannerSliderItemViewModel()
			{
				Title = "Stay Connected",
				SecondaryText = "Connect Seamlessly with Top-notch Tech",
				Text = "Unleash Your Connectivity!",
				ImageUrl = "https://i.pinimg.com/originals/4d/6e/e3/4d6ee35efaf1cc622ab654c0d7a86de7.png"
			},
			new BannerSliderItemViewModel()
			{
				Title = "Gaming Galore",
				SecondaryText = "Level Up with Gaming Tech Marvels",
				Text = "Power Up Your Playtime!",
				ImageUrl = "https://png.pngtree.com/png-vector/20220518/ourmid/pngtree-cartoon-gaming-accessories-accessory-professional-png-image_4688166.png"
			}
		];

		return this.View(items);
	}
}
