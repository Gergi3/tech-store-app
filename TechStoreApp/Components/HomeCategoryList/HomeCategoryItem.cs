using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.HomeCategoryList;

public class HomeCategoryItem : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		HomeCategoryItemViewModel item
	)
	{
		return this.View(item);
	}
}
