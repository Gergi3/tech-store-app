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
		ProductQueryParamsDTO queryParams
	)
	{
		List<ProductDTO> products = await this._productService.All(queryParams);

		List<ProductItemViewModel> productViewModels = this._mapper
			.Map<List<ProductItemViewModel>>(products);

		return this.View(new ProductListViewModel()
		{
			Items = productViewModels
		});
	}
}
