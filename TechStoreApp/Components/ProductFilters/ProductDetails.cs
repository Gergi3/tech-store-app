using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.ProductDetails;

public class ProductDetails : AuthViewComponent
{
	private readonly IProductService _productService;
	private readonly IReviewService _reviewService;
	private readonly IMapper _mapper;

	public ProductDetails(
		IProductService productService,
		IMapper mapper,
		IAccountService accountService,
		IReviewService reviewService)
		: base(accountService)
	{
		this._productService = productService;
		this._mapper = mapper;
		this._reviewService = reviewService;
	}

	public async Task<IViewComponentResult> InvokeAsync(
		string slug)
	{
		ProductDTO? product = await this._productService.GetBySlug(slug, this.CurrentUserId);

		if (product == null)
		{
			throw new ProductNotFoundException();
		}

		var topViewModel = this._mapper.Map<ProductDetailsTopViewModel>(product);
		var bottomViewModel = new ProductDetailsBottomViewModel()
		{
			ExtraInfoItems = this._mapper.Map<List<ExtraInfoViewModel>>(product.ExtraInfos),
			ReviewItems = this._mapper.Map<List<ReviewViewModel>>(product.Reviews),
			AverageRating = product.AverageRating,
			ProductId = product.Id,
			IsReviewed = await this._reviewService.Exists(this.CurrentUserId, product.Id)
		};

		return this.View(new ProductDetailsViewModel()
		{
			TopViewModel = topViewModel,
			BottomViewModel = bottomViewModel
		});
	}
}
