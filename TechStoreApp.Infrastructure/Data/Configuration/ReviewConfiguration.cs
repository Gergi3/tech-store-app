using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;
internal class ReviewConfiguration
	: IEntityTypeConfiguration<Review>
{
	public void Configure(
		EntityTypeBuilder<Review> builder)
	{
		builder.HasData(this.Seed());
	}

	public List<Review> Seed()
	{
		string[][] reviewMessages = [
			["Complete disappointment, didn't work, broke quickly.",
			"Waste of money, caused damage, frustrated with purchase.",
			"Terrible quality, fell apart within days, regret buying.",
			"Utterly disappointing, malfunctioned right out of the box, worst purchase ever"],

			["Fell short of expectations, functional but feels cheap.",
			"Wanted to like it, lacks features, expected more for price.",
			"Not terrible, but not great either, wouldn't buy again.",
			"Not as expected, lacks durability, wouldn't recommend"],

			["Okay product, not special, better options available.",
			"Functional but flawed, average quality, worth considering on a budget.",
			"Average performance, nothing outstanding, meets basic needs.",
			"Average performance, nothing remarkable, serves its purpose adequately"],

			["Pleased overall, performs well, minor issues.",
			"Happy with purchase, solid product, reliable performance.",
			"Good value for money, mostly satisfied, could be improved.",
			"Very satisfied, exceeded initial impressions, minor flaws"],

			["Love it! Exceeded expectations, game-changer.",
			"Absolutely recommend! Well-designed, user-friendly, worth every penny.",
			"Outstanding product, exceeded expectations, couldn't be happier.",
			"Exceptional quality, exceeded expectations, worth every cent."]
		];

		var reviews = new List<Review>();
		int reviewGuidHelper = 1;
		for (int i = 1; i < 100; i++)
		{
			var id = new Guid($"00000000-0000-0000-0000-{i.ToString("000000000000", CultureInfo.InvariantCulture)}");
			var random = new Random(id.GetHashCode() * 3);

			var reviewCount = random.Next(1, 15);

			for (int j = 1; j <= reviewCount; j++)
			{
				var stars = random.Next(1, 6);

				var textIndex = random.Next(0, 3);

				var userId = new Guid($"00000000-0000-0000-0000-{j.ToString("000000000000", CultureInfo.InvariantCulture)}");
				var review = new Review()
				{
					Id = new Guid($"{reviewGuidHelper.ToString("00000000", CultureInfo.InvariantCulture)}-0000-0000-0000-{i.ToString("000000000000", CultureInfo.InvariantCulture)}"),
					Stars = stars,
					Text = reviewMessages[stars - 1][textIndex],
					ProductsId = id,
					UserId = userId
				};
				reviewGuidHelper++;
				reviews.Add(review);
			}
		}

		return reviews;
	}
}
