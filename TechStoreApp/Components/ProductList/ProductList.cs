using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Components.ProductList;

public class ProductList : BaseViewComponent
{
	private readonly IProductService _productService;
	private readonly IMapper _mapper;
	private readonly IUIService _uiService;

	public ProductList(
		IProductService productService,
		IMapper mapper,
		IUIService uiService)
	{
		this._mapper = mapper;
		this._productService = productService;
		this._uiService = uiService;
	}

	public async Task<IViewComponentResult> InvokeAsync(
		ProductQueryParamsDTO query,
		bool layout = true
	)
	{
		var productsCount = await this._productService.Count(query);

		var productDTOs = await this._productService.All(query);
		var productViewModels = this._mapper
			.Map<List<ProductItemViewModel>>(productDTOs);

		var pagination = await this._uiService.ConstructProductPagination(query.Page, query.PerPage, productsCount);

		return this.View(new ProductListViewModel()
		{
			Items = productViewModels,
			Pagination = pagination,
			Layout = layout
		});
	}
}
