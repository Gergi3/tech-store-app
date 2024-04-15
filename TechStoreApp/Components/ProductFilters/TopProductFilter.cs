using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.ProductFilters;

public class TopProductFilter : BaseViewComponent
{
	private readonly IProductService _productService;
	private readonly IMapper _mapper;

	public TopProductFilter(
		IProductService productService,
		IMapper mapper)
	{
		this._productService = productService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var topRated = await this._productService.TopRated(5);
		var topRatedViewModels = this._mapper.Map<List<ProductItemViewModel>>(topRated);

		return this.View(topRatedViewModels);
	}
}
