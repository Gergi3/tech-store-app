using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Components.Wishlist;

public class Wishlist : BaseViewComponent
{
	private readonly IWishlistService _wishlistService;
	private readonly IMapper _mapper;

	public Wishlist(IWishlistService wishlistService, IMapper mapper)
	{
		this._wishlistService = wishlistService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync(
		Guid userId)
	{
		if (userId == default)
		{
			throw new UnexpectedUnauthenticatedUser();
		}

		var wishlistDTOs = await this._wishlistService.GetByUserId(userId);

		var wishlistViewModels = this._mapper
			.Map<List<WishlistItemViewModel>>(wishlistDTOs);

		return this.View(wishlistViewModels);
	}
}
