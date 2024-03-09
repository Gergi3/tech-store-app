using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.HomeProductList;

public class HomeProductItem : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		HomeProductListItemViewModel item
	)
	{
		return this.View(item);
	}
}
