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
	}
}
