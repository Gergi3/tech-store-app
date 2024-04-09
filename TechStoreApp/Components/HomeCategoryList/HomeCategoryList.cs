using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.HomeCategoryList;

public class HomeCategoryList : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		List<HomeCategoryItemViewModel> items
		)
	{
		return this.View(items);
	}
}
