using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Infrastructure.Data.EnumTypes;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.Shared;

public class HeaderCartBtn : AuthViewComponent
{
	private readonly ISessionService _sessionService;

	public HeaderCartBtn(
		IAccountService accountService,
		ISessionService sessionService)
		: base(accountService)
	{
		this._sessionService = sessionService;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var cartCount = await this._sessionService.Count(this.CurrentUserId, SessionStatus.InCart);

		return this.View(new HeaderCartBtnViewModel()
		{
			Count = cartCount
		});
	}
}
