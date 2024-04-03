using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;

public class WishlistConfiguration
	: IEntityTypeConfiguration<Wishlist>
{
	public void Configure(EntityTypeBuilder<Wishlist> builder)
	{
		builder
			.HasKey(w => new { w.ProductId, w.UserId });

		builder
			.Property(w => w.Quantity)
			.HasDefaultValue(1);
	}
}
