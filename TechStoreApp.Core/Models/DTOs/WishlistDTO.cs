
namespace TechStoreApp.Core.Models.DTOs;

public class WishlistDTO
{
	public Guid ProductId { get; set; }

	public string Name { get; set; } = null!;

	public decimal Price { get; set; }

	public string Slug { get; set; } = null!;

	public int Quantity { get; set; }
}
