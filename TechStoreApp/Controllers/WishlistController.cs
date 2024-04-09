using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Contracts;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Params;
using TechStoreApp.Core.Models.Params.Wishlist;
using TechStoreApp.Models.Pages;

namespace TechStoreApp.Controllers;

[Authorize]
public class WishlistController : BaseController
{
	private readonly IWishlistService _wishlistService;
	private readonly IUIService _uiService;

	public WishlistController(
		IWishlistService wishListService,
		IUIService uiService)
	{
		this._wishlistService = wishListService;
		this._uiService = uiService;
	}

	[HttpGet]
	public async Task<IActionResult> Index()
	{
		var breadcrumb = this._uiService.CreateWishlistBreadcrumb();

		var viewModel = new WishlistIndexPageViewModel()
		{
			Breadcrumb = breadcrumb
		};

		return this.View(viewModel);
	}

	[HttpPost]
	[EnableCors("AllowSpecificOrigins")]
	public async Task<IActionResult> ChangeStatus(
		WishlistChangeStatusParams reqParams)
	{
		if (!this.ModelState.IsValid)
		{
			return this.BadRequest();
		}

		var isDeleted = await this._wishlistService
			.ChangeStatus(this.CurrentUserId, reqParams.ProductId);

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
		WishlistChangeQuantityParams reqParams)
	{
		if (!this.ModelState.IsValid)
		{
			return this.BadRequest();
		}

		bool isUpdated = await this._wishlistService
			.EditQuantity(reqParams.ProductId, this.CurrentUserId, reqParams.NewQuantity);

		object jsonData = new
		{
			status = StatusCodes.Status200OK,
			isUpdated
		};

		return this.Json(jsonData);
	}
}
