using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Common.Extensions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Infrastructure.Data.EnumTypes;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.Wishlist;

public class Session : AuthViewComponent
{
	private readonly ISessionService _sessionService;
	private readonly IMapper _mapper;

	public Session(
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

		var total = await this._sessionService
			.GetTotal(this.CurrentUserId, status);

		var wishlistViewModels = this._mapper
			.Map<List<SessionItemViewModel>>(sessionDTOs);

		var viewModel = new SessionViewModel()
		{
			Items = wishlistViewModels,
			Status = status,
			TotalPrice = total.ToPriceString()
		};

		return this.View(viewModel);
	}
}
