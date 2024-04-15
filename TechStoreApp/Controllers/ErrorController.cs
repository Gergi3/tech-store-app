using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Models.Pages;

namespace TechStoreApp.Controllers;
public class ErrorController : BaseController
{
	public ErrorController(
		IAccountService accountService)
		: base(accountService)
	{ }

	public IActionResult Index(int statusCode = 404)
	{
		var viewModel = new ErrorPageViewModel()
		{
			StatusCode = statusCode,
			Text = "Looks like there was a problem loading your page!",
			Title = "Whoops, this is embarassing."
		};

		if (statusCode == 400)
		{
			viewModel.Title = "Oops! Something Went Wrong";
			viewModel.Text = "We couldn't understand your request. Make sure you're using the right format and all required information is provided.";
		}
		else if (statusCode == 401)
		{
			viewModel.Title = "Oops! Access Denied!";
			viewModel.Text = "You don't have permission to access this resource. Please sign in or provide valid credentials to proceed.";
		}
		else if (statusCode == 403)
		{
			viewModel.Title = "Oops! Access Forbidden!";
			viewModel.Text = "Sorry, you're not allowed to access this page. If you believe this is a mistake, please contact our support team for assistance.";
		}
		else if (statusCode == 404)
		{
			viewModel.Title = "Oops! Page Not Found!";
			viewModel.Text = "We couldn't find what you were looking for. Double-check the URL or try navigating back to the homepage.";
		}
		else if (statusCode == 405)
		{
			viewModel.Title = "Oops! Page Not Found!";
			viewModel.Text = "We couldn't find what you were looking for. Double-check the URL or try navigating back to the homepage.";
		}
		else if (statusCode >= 500)
		{
			viewModel.Title = "Oops! Something Broke on Our End!";
			viewModel.Text = "Our server encountered an unexpected issue. Don't worry, our team has been notified and we're working to fix it ASAP. Please try again later.";
		}

		return this.View(viewModel);
	}
}
