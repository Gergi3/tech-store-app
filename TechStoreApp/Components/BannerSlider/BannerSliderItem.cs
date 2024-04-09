using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.BannerSlider;

public class BannerSliderItem : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		BannerSliderItemViewModel item
	)
	{
		return this.View(item);
	}
}
