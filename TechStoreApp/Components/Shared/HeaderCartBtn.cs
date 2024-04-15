using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.Shared;

public class HeaderCartBtn : AuthViewComponent
{
	private readonly IWishlistService _wishlistService;

	public HeaderCartBtn(
		IAccountService accountService,
		IWishlistService wishlistService)
		: base(accountService)
	{
		this._wishlistService = wishlistService;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var cartCount = 0;

		return this.View(new HeaderCartBtnViewModel()
		{
			Count = cartCount
		});
	}
}
