using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Common;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Models.Components;
using TechStoreApp.Infrastructure.Data.EnumTypes;

namespace TechStoreApp.Components.Shared;

public class HeaderWishlistBtn : AuthViewComponent
{
	private readonly ISessionService _sessionService;

	public HeaderWishlistBtn(
		IAccountService accountService,
		ISessionService sessionService)
		: base(accountService)
	{
		this._sessionService = sessionService;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var wishlistCount = await this._sessionService.Count(this.CurrentUserId, SessionStatus.Wishlisted);

		return this.View(new HeaderWishlistBtnViewModel()
		{
			Count = wishlistCount
		});
	}
}
