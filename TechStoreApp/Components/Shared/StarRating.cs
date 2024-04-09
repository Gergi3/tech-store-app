using Microsoft.AspNetCore.Mvc;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Components.Shared;

public class StarRating : BaseViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(
		int stars,
		int reviews)
	{
		return this.View(new StarRatingViewModel()
		{
			Reviews = reviews,
			Stars = stars
		});
	}
}
