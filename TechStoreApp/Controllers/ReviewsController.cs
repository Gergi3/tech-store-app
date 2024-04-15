using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Models.Params;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Controllers;

[Authorize]
public class ReviewsController : BaseController
{
	private readonly IReviewService _reviewService;
	private readonly IMapper _mapper;

	public ReviewsController(
		IReviewService reviewService,
		IAccountService accountService,
		IMapper mapper)
		: base(accountService)
	{
		this._reviewService = reviewService;
		this._mapper = mapper;
	}

	[HttpPost]
	public async Task<IActionResult> Create(
		ReviewCreateParams query)
	{
		if (!this.ModelState.IsValid)
		{
			return this.BadRequest();
		}

		var exists = await this._reviewService.Exists(this.CurrentUserId, query.ProductsId);
		if (exists)
		{
			return this.BadRequest();
		}

		var review = await this._reviewService.Create(query, this.CurrentUserId);
		var reviewViewModel = this._mapper.Map<ReviewViewModel>(review);

		return this.PartialView("_Review", reviewViewModel);
	}
}
