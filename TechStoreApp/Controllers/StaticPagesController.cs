using Microsoft.AspNetCore.Mvc;

namespace TechStoreApp.Controllers;
public class StaticPagesController : Controller
{
	[HttpGet]
	public IActionResult PrivacyPolicy()
	{
		return this.View();
	}

	[HttpGet]
	public IActionResult TermsOfService()
	{
		return this.View();
	}

}
