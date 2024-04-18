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
	private readonly IOrderService _orderService;
	private readonly IUIService _uiService;

	public SessionController(
		ISessionService sessionService,
		IUIService uiService,
		IAccountService accountService,
		IOrderService orderService)
		: base(accountService)
	{
		this._sessionService = sessionService;
		this._uiService = uiService;
		this._orderService = orderService;
	}

	[HttpGet]
	public async Task<IActionResult> Index(
		SessionStatus status)
	{
		var breadcrumb = this._uiService.CreateSessionBreadcrumb(status);

		var viewModel = new SessionIndexPageViewModel()
		{
			Breadcrumb = breadcrumb,
			Status = status,
		};

		return this.View(nameof(Index), viewModel);
	}

	[HttpGet]
	[Route("cart/checkout")]
	public async Task<IActionResult> Checkout()
	{
		var count = await this._sessionService.Count(this.CurrentUserId, SessionStatus.InCart);
		if (count <= 0)
		{
			return this.BadRequest();
		};

		return this.View();
	}

	[HttpPost]
	[Route("cart/checkout")]
	public async Task<IActionResult> Checkout(
		OrderParams orderParams)
	{
		if (!this.ModelState.IsValid)
		{
			return this.View();
		}

		var count = await this._sessionService.Count(this.CurrentUserId, SessionStatus.InCart);
		if (count <= 0)
		{
			return this.BadRequest();
		};

		await this._orderService.Create(orderParams, this.CurrentUserId);

		return this.RedirectToAction("Index", "Products");
	}

	[HttpGet]
	[Route("cart")]
	public async Task<IActionResult> Cart()
	{
		return await this.Index(status: SessionStatus.InCart);
	}

	[HttpGet]
	[Route("wishlist")]
	public async Task<IActionResult> Wishlist()
	{
		return await this.Index(status: SessionStatus.Wishlisted);
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
