using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Converters;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;

internal class ProductConfiguration
	: IEntityTypeConfiguration<Product>
{
	public void Configure(
		EntityTypeBuilder<Product> builder)
	{
		builder.Property(c => c.Slug)
			.HasConversion(typeof(SlugValueConverter));

		builder.Property(c => c.ImageUrl)
			.HasDefaultValue("/img/product-default.png");

		builder.HasData(this.Seed());
	}

	public List<Product> Seed()
	{
		var products = new List<Product>();

		for (int i = 1; i < 1000; i++)
		{
			var id = new Guid($"00000000-0000-0000-0000-{i.ToString("000000000000", CultureInfo.InvariantCulture)}");
			var priceRandom = new Random(id.GetHashCode());
			var price = priceRandom.Next(3, 341) + ((decimal)priceRandom.Next(0, 99) / 100);
			products.Add(new Product()
			{
				Description = "Some product description",
				Name = $"Some tech product name {i}",
				Price = price,
				Id = id,
				ImageUrl = $"https://picsum.photos/seed/{id}/780/1050",
				Slug = $"Some tech product name {i}"
			});
		}

		return products;
	}
}
