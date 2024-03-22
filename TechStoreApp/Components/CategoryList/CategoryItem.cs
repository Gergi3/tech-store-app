using Microsoft.AspNetCore.Mvc;

namespace TechStoreApp.Components.CategoryList;

public class CategoryItem : BaseViewComponent
{

	public async Task<IViewComponentResult> InvokeAsync(
		CategoryItemViewModel item
	)
	{
		return this.View(item);
	}
}
