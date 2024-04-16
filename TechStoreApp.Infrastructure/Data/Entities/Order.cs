using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common;
using TechStoreApp.Common.Extensions;
using TechStoreApp.Infrastructure.Data.Configuration;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(OrderConfiguration))]
public class Order
{
	[Key]
	public Guid Id { get; set; }

	[Required]
	public string FirstName { get; set; } = null!;

	[Required]
	public string LastName { get; set; } = null!;

	public string? CompanyName { get; set; }

	[Required]
	public string Country { get; set; } = null!;

	[Required]
	public string City { get; set; } = null!;

	[Required]
	public string Address { get; set; } = null!;

	[Required]
	public string Phone { get; set; } = null!;

	public string? OrderNotes { get; set; }

	[Column(TypeName = DataConstants.SqlServerTypes.MoneyType)]
	public decimal Price { get; set; }

	[ForeignKey(nameof(UserId))]
	public virtual AppUser User { get; set; } = null!;
	public Guid UserId { get; set; }

	public List<Product> Products { get; set; } = [];
	public List<OrderProduct> OrderProducts { get; set; } = [];

	public override string ToString()
	{
		return $"{this.FirstName} {this.LastName} ({this.Price.ToPriceString()})";
	}
}
