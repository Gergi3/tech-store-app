using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;
internal class CartItemConfiguration
	: IEntityTypeConfiguration<CartItem>
{
	public void Configure(
		EntityTypeBuilder<CartItem> builder)
	{
		builder
			.HasKey(c => new { c.ProductId, c.UserId });

		builder
			.Property(c => c.Quantity)
			.HasDefaultValue(1);
	}
}
