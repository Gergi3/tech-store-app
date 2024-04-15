using System.Web;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Contracts;

namespace TechStoreApp.Controllers;

public class BaseController : Controller
{
	private readonly IAccountService _accountService;

	public BaseController(
		IAccountService _accountService)
	{
		this._accountService = _accountService;
	}

	public Guid CurrentUserId
		=> this._accountService.GetUserId(this.User);

	public bool IsAuthenticated
		=> this._accountService.GetIsAuthenticated(this.User);

	[NonAction]
	public void DropQueryParam(string key)
	{
		var url = new Uri(this.Request.GetEncodedUrl());

		var queryStr = HttpUtility.ParseQueryString(url.Query);

		queryStr.Remove(key);
	}
}
