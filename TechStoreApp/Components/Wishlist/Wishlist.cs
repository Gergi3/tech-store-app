using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.Wishlist;

public class Wishlist : AuthViewComponent
{
	private readonly IWishlistService _wishlistService;
	private readonly IMapper _mapper;

	public Wishlist(
		IWishlistService wishlistService,
		IMapper mapper,
		IAccountService accountService)
		: base(accountService)
	{
		this._wishlistService = wishlistService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var wishlistDTOs = await this._wishlistService.GetByUserId(this.CurrentUserId);

		var wishlistViewModels = this._mapper
			.Map<List<WishlistItemViewModel>>(wishlistDTOs);

		return this.View(wishlistViewModels);
	}
}
