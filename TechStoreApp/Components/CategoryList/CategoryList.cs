using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.CategoryList;

public class CategoryList : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		List<CategoryListItemViewModel> items
	)
	{
		return this.View(items);
	}
}
