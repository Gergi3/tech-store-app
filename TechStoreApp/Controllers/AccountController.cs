using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Auth;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Controllers;

[Authorize]
public class AccountController : BaseController
{
	private readonly SignInManager<AppUser> _signInManager;
	private readonly UserManager<AppUser> _userManager;
	private readonly IAccountService _accountService;

	public AccountController(
		IAccountService accountService,
		SignInManager<AppUser> signInManager,
		UserManager<AppUser> userManager)
		: base(accountService)
	{
		this._signInManager = signInManager;
		this._userManager = userManager;
		this._accountService = accountService;
	}

	[HttpGet]
	[AllowAnonymous]
	public IActionResult Register(
		string? returnUrl)
	{
		var viewModel = new RegisterViewModel();

		if (returnUrl != null)
		{
			viewModel.ReturnUrl = returnUrl;
		}

		return this.View(viewModel);
	}

	[HttpPost]
	[AllowAnonymous]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> Register(
		RegisterViewModel model)
	{
		if (!this.ModelState.IsValid)
		{
			return this.View(model);
		}

		var (result, user) = await this._accountService.Create(model);

		if (!result.Succeeded)
		{
			foreach (var error in result.Errors)
			{
				this.ModelState.AddModelError(string.Empty, error.Description);
			}

			return this.View(model);
		}

		await this._signInManager.SignInAsync(user, isPersistent: true);

		return this.Redirect(model.ReturnUrl);
	}

	[HttpGet]
	[AllowAnonymous]
	public IActionResult Login(
		string? returnUrl)
	{
		var viewModel = new LoginViewModel();

		if (returnUrl != null)
		{
			viewModel.ReturnUrl = returnUrl;
		}

		return this.View(viewModel);
	}

	[HttpPost]
	[AllowAnonymous]
	public async Task<IActionResult> Login(
		LoginViewModel model)
	{
		if (!this.ModelState.IsValid)
		{
			return this.View(model);
		}

		var user = await this._accountService.Get(model);

		if (user == null)
		{
			this.ModelState.AddModelError(string.Empty, "Invalid email or password!");

			return this.View(model);
		}

		var result = await this._signInManager.PasswordSignInAsync(
			user,
			model.Password,
			isPersistent: model.RememberMe,
			lockoutOnFailure: false);

		if (result.IsNotAllowed || result.IsLockedOut || !result.Succeeded)
		{
			this.ModelState.AddModelError(string.Empty, "Invalid email or password!");

			return this.View(model);
		}

		return this.Redirect(model.ReturnUrl);
	}

	[HttpGet]
	public async Task<IActionResult> Logout(
		string returnUrl = "/Account/Login")
	{
		await this._signInManager.SignOutAsync();

		return this.Redirect(returnUrl);
	}

	[HttpGet]
	public IActionResult MyProfile()
	{
		return this.View();
	}
}
