using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Entities;
using static TechStoreApp.Common.SeedConstants.Category;

namespace TechStoreApp.Infrastructure.Data.Configuration;

internal class ProductCategoryConfiguration
	: IEntityTypeConfiguration<ProductCategory>
{
	public void Configure(
		EntityTypeBuilder<ProductCategory> builder)
	{
		builder
			.HasKey(pc => new { pc.ProductsId, pc.CategoriesId });

		builder.HasData(this.Seed());
	}

	public List<ProductCategory> Seed()
	{
		var productCategories = new List<ProductCategory>();
		var categories = CategoryIds;
		for (int i = 1; i < 1000; i++)
		{
			var productId = new Guid($"00000000-0000-0000-0000-{i.ToString("000000000000", CultureInfo.InvariantCulture)}");
			var categoryIndexRandom = new Random(productId.GetHashCode());

			var categoriesCount = categoryIndexRandom.Next(1, 5);
			List<int> alreadyUsed = [];
			for (int j = 0; j < categoriesCount; j++)
			{
				var categoryIndex = categoryIndexRandom.Next(0, categories.Length);
				if (alreadyUsed.Contains(categoryIndex))
				{
					continue;

				}

				alreadyUsed.Add(categoryIndex);

				var productCategory = new ProductCategory()
				{
					ProductsId = productId,
					CategoriesId = new Guid(categories[categoryIndex])
				};

				productCategories.Add(productCategory);
			}
		}

		return productCategories;
	}
}
