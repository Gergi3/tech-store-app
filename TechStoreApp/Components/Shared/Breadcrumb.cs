using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.Shared;

public class Breadcrumb : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		List<BreadcrumbItemViewModel> items
	)
	{
		return this.View(items);
	}
}
