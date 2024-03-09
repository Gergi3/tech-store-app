using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.BannerSlider;

public class BannerSlider : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		List<BannerSliderItemViewModel> items
	)
	{
		return this.View(items);
	}
}
