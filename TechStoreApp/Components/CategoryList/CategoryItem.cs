using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.CategoryList;

public class CategoryItem : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		CategoryListItemViewModel item
	)
	{
		return this.View(item);
	}
}
