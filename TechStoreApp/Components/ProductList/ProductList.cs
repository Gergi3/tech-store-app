using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Models.Components;

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
		ProductQueryParams query,
		bool layout = true
	)
	{
		var productDTOs = await this._productService
			.All(query, this.CurrentUserId);

		var productViewModels = this._mapper
			.Map<List<ProductItemViewModel>>(productDTOs);

		var productsCount = await this._productService
			.Count(query);

		var pagination = this._uiService
			.CreateProductPagination(query.Page, query.PerPage, productsCount);

		return this.View(new ProductListViewModel()
		{
			Items = productViewModels,
			Pagination = pagination,
			Layout = layout
		});
	}
}
