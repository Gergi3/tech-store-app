using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using TechStoreApp.Core.Models.Auth;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Core.Contracts;

public interface IAccountService
{
	Task<AppUser?> Get(
		LoginViewModel model);

	Task<Tuple<IdentityResult, AppUser>> Create(
		RegisterViewModel model);

	public Guid GetUserId(
		ClaimsPrincipal userPrincipal);

	public bool GetIsAuthenticated(
		ClaimsPrincipal userPrincipal);
}
