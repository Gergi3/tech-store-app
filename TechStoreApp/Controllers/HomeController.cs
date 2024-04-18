using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;

namespace TechStoreApp.Controllers;

[Authorize]
public class HomeController : BaseController
{
	public HomeController(
		IAccountService accountService)
		: base(accountService)
	{

	}

	[AllowAnonymous]
	public IActionResult Index()
	{
		return this.View();
	}
}
