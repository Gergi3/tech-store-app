
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.HomeFeatureList;

public class HomeFeatureItem : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		HomeFeatureItemViewModel item
		)
	{
		return this.View(item);
	}
}
