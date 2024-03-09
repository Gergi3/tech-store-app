using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.ProductList;

public class ProductItem : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		ProductListItemViewModel item
		)
	{
		return this.View(item);
	}
}
