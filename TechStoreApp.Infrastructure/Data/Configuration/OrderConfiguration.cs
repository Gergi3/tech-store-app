using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;
public class OrderConfiguration
	: IEntityTypeConfiguration<Order>
{
	public void Configure(
		EntityTypeBuilder<Order> builder)
	{
		builder.HasMany(o => o.Products)
			.WithMany(p => p.Orders)
			.UsingEntity<OrderProduct>();
	}
}
