using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Components.ProductDetails;

public class ProductDetails : BaseViewComponent
{
	private readonly IProductService _productService;
	private readonly IMapper _mapper;

	public ProductDetails(IProductService productService, IMapper mapper)
	{
		this._productService = productService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync(
		string slug
	)
	{
		ProductDTO? product = await this._productService.GetBySlug(slug);

		if (product == null)
		{
			throw new ProductNotFoundException();
		}

		var topViewModel = this._mapper.Map<ProductDetailsTopViewModel>(product);
		var bottomViewModel = new ProductDetailsBottomViewModel();

		return this.View(new ProductDetailsViewModel()
		{
			TopViewModel = topViewModel,
			BottomViewModel = bottomViewModel
		});
	}
}
