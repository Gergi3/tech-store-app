using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Common.Extensions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Infrastructure.Data.EnumTypes;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.CheckoutOrderInfo;

public class CheckoutOrderInfo : AuthViewComponent
{
	private readonly ISessionService _sessionService;
	private readonly IMapper _mapper;

	public CheckoutOrderInfo(
		IAccountService accountService,
		ISessionService sessionService,
		IMapper mapper)
		: base(accountService)
	{
		this._sessionService = sessionService;
		this._mapper = mapper;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		var sessionDTOs = await this._sessionService
			.GetByUserId(this.CurrentUserId, SessionStatus.InCart);

		var total = await this._sessionService
			.GetTotal(this.CurrentUserId, SessionStatus.InCart);

		var sessionViewModels = this._mapper
			.Map<List<SessionItemViewModel>>(sessionDTOs);

		var viewModel = new SessionViewModel()
		{
			Items = sessionViewModels,
			TotalPrice = total.ToPriceString()
		};

		return this.View(viewModel);
	}
}
