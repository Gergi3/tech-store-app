using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data.Configuration;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(WishlistConfiguration))]
public class Wishlist
{
	[ForeignKey(nameof(User))]
	public Guid UserId { get; set; }
	public AppUser User { get; set; } = null!;

	[ForeignKey(nameof(Product))]
	public Guid ProductId { get; set; }
	public Product Product { get; set; } = null!;

	[Required]
	[Range(1, int.MaxValue)] // validation purposes
	public int Quantity { get; set; }
}
