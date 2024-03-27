using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;

namespace TechStoreApp.Components.ProductList;

public class ProductList : BaseViewComponent
{
	private readonly IProductService _productService;
	private readonly IMapper _mapper;

	public ProductList(IProductService productService, IMapper mapper)
	{
		this._mapper = mapper;
		this._productService = productService;
	}

	public async Task<IViewComponentResult> InvokeAsync(
		ProductQueryParamsDTO query
	)
	{
		int productsCount = await this._productService.Count(query);

		var productDTOs = await this._productService.All(query);
		var productViewModels = this._mapper
			.Map<List<ProductItemViewModel>>(productDTOs);

		return this.View(new ProductListViewModel()
		{
			Items = productViewModels,
			AllCount = productsCount,
			Page = query.Page,
			PerPage = query.PerPage
		});
	}
}
