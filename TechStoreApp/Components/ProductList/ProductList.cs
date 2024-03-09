using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.ProductList;

public class ProductList : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		List<ProductListItemViewModel> items
		)
	{
		return this.View(items);
	}
}
