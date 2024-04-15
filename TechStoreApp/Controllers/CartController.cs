using Microsoft.AspNetCore.Mvc;

namespace TechStoreApp.Controllers;
public class CartController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
