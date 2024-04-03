using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Components;
using TechStoreApp.ViewModels.Pages;

namespace TechStoreApp.Controllers;

[Authorize]
public class WishlistController : BaseController
{
	private readonly IWishlistService _wishlistService;

	public WishlistController(IWishlistService wishListService)
	{
		this._wishlistService = wishListService;
	}

	[HttpGet]
	public IActionResult Index()
	{
		var breadcrumb = new List<BreadcrumbItemViewModel>()
		{
			new()
			{
				Name= "Home",
				Path = ("Home", "Index")
			},
			new()
			{
				Name = "My Wishlist"
			}
		};

		var viewModel = new WishlistIndexPageViewModel()
		{
			CurrentUserId = this.CurrentUserId,
			Breadcrumb = breadcrumb
		};

		return this.View(viewModel);
	}

	[HttpPost]
	[EnableCors("AllowSpecificOrigins")]
	public async Task<IActionResult> ChangeStatus(Guid productId)
	{
		var isDeleted = await this._wishlistService.ChangeStatus(
			userId: this.CurrentUserId,
			productId: productId);

		return this.Json(new
		{
			status = StatusCodes.Status200OK,
			isDeleted
		});
	}

	[HttpPost]
	[EnableCors("AllowSpecificOrigins")]
	public async Task<IActionResult> ChangeQuantity(Guid productId, int newQuantity)
	{
		bool isUpdated = await this._wishlistService
			.EditQuantity(productId, this.CurrentUserId, newQuantity);

		return this.Json(new
		{
			status = StatusCodes.Status200OK,
			isUpdated
		});
	}
}
