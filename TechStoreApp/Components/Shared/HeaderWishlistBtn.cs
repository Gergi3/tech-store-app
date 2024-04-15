using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Common;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.Shared;

public class HeaderWishlistBtn : AuthViewComponent
{
	private readonly IWishlistService _wishlistService;

	public HeaderWishlistBtn(
		IAccountService accountService,
		IWishlistService wishlistService)
		: base(accountService)
	{
		this._wishlistService = wishlistService;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var wishlistCount = await this._wishlistService.Count(this.CurrentUserId);

		return this.View(new HeaderWishlistBtnViewModel()
		{
			Count = wishlistCount
		});
	}
}
