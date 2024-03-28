using Microsoft.AspNetCore.Mvc;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Components.ProductDetails;

public class ProductDetailsBottom : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		ProductDetailsBottomViewModel model
	)
	{
		return this.View(model);
	}
}
