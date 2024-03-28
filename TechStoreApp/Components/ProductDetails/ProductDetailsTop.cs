using Microsoft.AspNetCore.Mvc;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Components.ProductDetails;

public class ProductDetailsTop : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(ProductDetailsTopViewModel model)
	{
		return this.View(model);
	}
}
