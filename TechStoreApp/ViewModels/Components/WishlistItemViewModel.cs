using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.ViewModels.Components;

public class WishlistItemViewModel
{
	public Guid ProductId { get; set; }

	public string Name { get; set; } = null!;

	public string Price { get; set; } = null!;

	public string Slug { get; set; } = null!;

	public int Quantity { get; set; }
}
