using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;

internal class ProductCategoryConfiguration
	: IEntityTypeConfiguration<ProductCategory>
{
	public void Configure(
		EntityTypeBuilder<ProductCategory> builder)
	{
		builder
			.HasKey(pc => new { pc.ProductsId, pc.CategoriesId });
	}
}
