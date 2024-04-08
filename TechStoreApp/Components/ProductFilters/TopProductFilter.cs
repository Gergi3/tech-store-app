using Microsoft.AspNetCore.Mvc;

namespace TechStoreApp.Components.ProductFilters;

public class TopProductFilter : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync()
	{
		return this.View();
	}
}
