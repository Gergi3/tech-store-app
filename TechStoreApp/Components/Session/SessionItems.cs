using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Infrastructure.Data.EnumTypes;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.Wishlist;

public class SessionItems : AuthViewComponent
{
	private readonly ISessionService _sessionService;
	private readonly IMapper _mapper;

	public SessionItems(
		ISessionService sessionService,
		IMapper mapper,
		IAccountService accountService)
		: base(accountService)
	{
		this._sessionService = sessionService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync(SessionStatus status = SessionStatus.Wishlisted)
	{
		var sessionDTOs = await this._sessionService
			.GetByUserId(this.CurrentUserId, status);

		var wishlistViewModels = this._mapper
			.Map<List<WishlistItemViewModel>>(sessionDTOs);

		return this.View(wishlistViewModels);
	}
}
