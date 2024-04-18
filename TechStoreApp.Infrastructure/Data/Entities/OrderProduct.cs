using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data.Configuration;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(OrderProductConfiguration))]
public class OrderProduct
{
	[Required]
	[ForeignKey(nameof(ProductsId))]
	public virtual Product Product { get; set; } = null!;
	public Guid ProductsId { get; set; }

	[Required]
	[ForeignKey(nameof(OrdersId))]
	public virtual Order Order { get; set; } = null!;
	public Guid OrdersId { get; set; }

	[Required]
	public int Quantity { get; set; }
}
