using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Auth;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Services;

public class AccountService : IAccountService
{
	private readonly UserManager<AppUser> _userManager;

	public AccountService(
		UserManager<AppUser> userManager)
	{
		this._userManager = userManager;
	}

	public async Task<Tuple<IdentityResult, AppUser>> Create(
		RegisterViewModel model)
	{
		var user = new AppUser()
		{
			Email = model.Email,
			UserName = model.UserName,
		};

		var result = await this._userManager.CreateAsync(user, model.Password);

		return new(result, user);
	}

	public async Task<AppUser?> Get(
		LoginViewModel model)
	{
		return await this._userManager.FindByEmailAsync(model.Email);
	}

	public Guid GetUserId(
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

	public bool GetIsAuthenticated(
		ClaimsPrincipal userPrincipal)
	{
		return userPrincipal?.Identity?.IsAuthenticated ?? false;
	}
}
