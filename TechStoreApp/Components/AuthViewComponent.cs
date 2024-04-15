using TechStoreApp.Core.Contracts;

namespace TechStoreApp.Components;

public abstract class AuthViewComponent : BaseViewComponent
{
	private readonly IAccountService _accountService;

	public AuthViewComponent(
		IAccountService accountService)
	{
		this._accountService = accountService;
	}

	public Guid CurrentUserId
		=> this._accountService.GetUserId(this.UserClaimsPrincipal);

	public bool IsAuthenticated
		=> this._accountService.GetIsAuthenticated(this.UserClaimsPrincipal);
}
