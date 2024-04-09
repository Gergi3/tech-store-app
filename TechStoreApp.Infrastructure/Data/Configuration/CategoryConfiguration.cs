using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Converters;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;

internal class CategoryConfiguration
	: IEntityTypeConfiguration<Category>
{
	public void Configure(
		EntityTypeBuilder<Category> builder)
	{
		builder.HasMany(c => c.Products)
			.WithMany(p => p.Categories)
			.UsingEntity<ProductCategory>();

		builder.Property(c => c.Slug)
			.HasConversion(typeof(SlugValueConverter));
	}
}
