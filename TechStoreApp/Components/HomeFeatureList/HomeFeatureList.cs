using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.HomeFeatureList;

public class HomeFeatureList : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		List<HomeFeatureItemViewModel> items
	)
	{
		return this.View(items);
	}
}
