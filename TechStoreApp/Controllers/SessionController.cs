using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Params;
using TechStoreApp.Core.Models.Params.Wishlist;
using TechStoreApp.Infrastructure.Data.EnumTypes;
using TechStoreApp.Models.Pages;

namespace TechStoreApp.Controllers;

[Authorize]
public class SessionController : BaseController
{
	private readonly ISessionService _sessionService;
	private readonly IUIService _uiService;

	public SessionController(
		ISessionService sessionService,
		IUIService uiService,
		IAccountService accountService)
		: base(accountService)
	{
		this._sessionService = sessionService;
		this._uiService = uiService;
	}

	[HttpGet]
	public async Task<IActionResult> Index(
		SessionStatus status)
	{
		var breadcrumb = this._uiService.CreateSessionBreadcrumb(status);

		var viewModel = new SessionIndexPageViewModel()
		{
			Breadcrumb = breadcrumb,
			Status = status
		};

		return this.View(viewModel);
	}

	[HttpGet]
	public async Task<IActionResult> Cart()
	{
		var routeValues = new { status = SessionStatus.InCart };
		return this.RedirectToActionPreserveMethod("Index", routeValues: routeValues);
	}

	[HttpGet]
	public async Task<IActionResult> Wishlist()
	{
		var routeValues = new { status = SessionStatus.Wishlisted };
		return this.RedirectToActionPreserveMethod("Index", routeValues: routeValues);
	}

	[HttpPost]
	[EnableCors("AllowSpecificOrigins")]
	public async Task<IActionResult> ChangeStatus(
		SessionChangeStatusParams reqParams)
	{
		if (!this.ModelState.IsValid)
		{
			return this.BadRequest();
		}

		var isDeleted = await this._sessionService
			.ChangeStatus(this.CurrentUserId, reqParams.ProductId, reqParams.Status);

		object jsonData = new
		{
			status = StatusCodes.Status200OK,
			isDeleted
		};

		return this.Json(jsonData);
	}

	[HttpPost]
	[EnableCors("AllowSpecificOrigins")]
	public async Task<IActionResult> ChangeQuantity(
		SessionChangeQuantityParams reqParams)
	{
		if (!this.ModelState.IsValid)
		{
			return this.BadRequest();
		}

		bool isUpdated = await this._sessionService
			.EditQuantity(reqParams.ProductId, this.CurrentUserId, reqParams.Status, reqParams.NewQuantity);

		object jsonData = new
		{
			status = StatusCodes.Status200OK,
			isUpdated
		};

		return this.Json(jsonData);
	}
}
