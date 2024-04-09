using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TechStoreApp.Common;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;

namespace TechStoreApp.Controllers;

public class BaseController : Controller
{
	[NonAction]
	internal static Guid GetUserId(
		ClaimsPrincipal userPrincipal)
	{
		string? userId = userPrincipal
			?.Claims
			?.FirstOrDefault(
				x => x.Type == ClaimTypes.NameIdentifier)
			?.Value;

		if (userId == null)
		{
			return default;
		}

		return new Guid(userId);
	}

	[NonAction]
	internal static bool GetIsAuthenticated(
		ClaimsPrincipal userPrincipal)
	{
		return userPrincipal?.Identity?.IsAuthenticated ?? false;
	}

	public Guid CurrentUserId => GetUserId(this.User);

	public bool IsAuthenticated => GetIsAuthenticated(this.User);

	public override async Task OnActionExecutionAsync(
		ActionExecutingContext context,
		ActionExecutionDelegate next)
	{
		var userPrincipal = context.HttpContext.User;

		if (userPrincipal?.Identity?.IsAuthenticated ?? false)
		{
			var controller = context.Controller as Controller;
			if (controller == null)
			{
				throw new UnexpectedNullController();
			}

			var wishlistService = context.HttpContext.RequestServices.GetService<IWishlistService>();
			if (wishlistService == null)
			{
				throw new UnexpectedNullService();
			}

			Guid userId = GetUserId(userPrincipal);
			var wishlistCount = await wishlistService.Count(userId);

			controller.ViewData[UIConstants.ViewData.WishlistCountIdentifier] = wishlistCount;
		}

		await next();
	}
}
