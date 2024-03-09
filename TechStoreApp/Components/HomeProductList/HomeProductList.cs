using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.HomeProductList;

public class HomeProductList : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		List<HomeProductListItemViewModel> items,
		string title
	)
	{
		this.ViewBag.Title = title;
		return this.View(items);
	}
}
