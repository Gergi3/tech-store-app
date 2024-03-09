using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Components.Shared;

public class StarRating : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		int stars,
		int reviews
	)
	{
		var starRatingViewModel = new StarRatingViewModel()
		{
			Reviews = reviews,
			Stars = stars
		};

		return this.View(starRatingViewModel);
	}
}
