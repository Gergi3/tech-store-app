using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Components.ProductDetails;

public class ProductDetails : BaseViewComponent
{
	private readonly IProductService _productService;
	private readonly IWishlistService _wishlistService;
	private readonly IMapper _mapper;

	public ProductDetails(
		IProductService productService,
		IWishlistService wishlistService,
		IMapper mapper)
	{
		this._productService = productService;
		this._wishlistService = wishlistService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync(
		Guid userId,
		string slug)
	{
		ProductDTO? product = await this._productService.GetBySlug(slug);

		if (product == null)
		{
			throw new ProductNotFoundException();
		}

		var topViewModel = this._mapper.Map<ProductDetailsTopViewModel>(product);

		if (userId != default)
		{
			topViewModel.IsWishlisted = await this._wishlistService
				.ExistsByProductAndUserIds(product.Id, userId);
		}

		return this.View(new ProductDetailsViewModel()
		{
			TopViewModel = topViewModel,
			BottomViewModel = new ProductDetailsBottomViewModel()
		});
	}
}
