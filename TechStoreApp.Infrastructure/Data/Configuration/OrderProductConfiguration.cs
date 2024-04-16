using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;

public class OrderProductConfiguration
	: IEntityTypeConfiguration<OrderProduct>
{
	public void Configure(
		EntityTypeBuilder<OrderProduct> builder)
	{
		builder
			.HasKey(op => new { op.ProductsId, op.OrdersId });
	}
}
