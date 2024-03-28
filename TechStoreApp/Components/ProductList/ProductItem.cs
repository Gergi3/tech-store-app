using Microsoft.AspNetCore.Mvc;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Components.ProductList;

public class ProductItem : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		ProductItemViewModel item
	)
	{
		return View(item);
	}
}
