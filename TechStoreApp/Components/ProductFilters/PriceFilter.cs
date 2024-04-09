using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.ProductFilters;

public class PriceFilter : BaseViewComponent
{
	private readonly IProductService _productService;

	public PriceFilter(IProductService productService)
	{
		this._productService = productService;
	}

	public async Task<IViewComponentResult> InvokeAsync(
		ProductQueryParams query)
	{
		(decimal min, decimal max) = await this._productService.GetMinAndMax(query.CategorySlug);

		string minStr = this.NormalizePriceFilter(Math.Floor, min);
		string maxStr = this.NormalizePriceFilter(Math.Ceiling, max);
		string minSelectedStr = this.NormalizePriceFilter(Math.Floor, query.FromPrice ?? min);
		string maxSelectedStr = this.NormalizePriceFilter(Math.Ceiling, query.ToPrice ?? max);

		return this.View(new PriceFilterViewModel()
		{
			Min = minStr,
			Max = maxStr,
			MinSelected = minSelectedStr,
			MaxSelected = maxSelectedStr,
		});
	}
	private string NormalizePriceFilter(Func<decimal, decimal> func, decimal num)
		=> ((int)func.Invoke(num)).ToString(CultureInfo.InvariantCulture);
}
