namespace TechStoreApp.Core.Models.DTOs;

public class WishlistDTO
{
	public Guid ProductId { get; set; }

	public string ProductName { get; set; } = null!;

	public decimal ProductPrice { get; set; }

	public string ProductSlug { get; set; } = null!;

	public int Quantity { get; set; }
}
