using Microsoft.AspNetCore.Mvc;

namespace TechStoreApp.Components.ProductList;

public class ProductItem : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		ProductItemViewModel item
	)
	{
		return this.View(item);
	}
}
