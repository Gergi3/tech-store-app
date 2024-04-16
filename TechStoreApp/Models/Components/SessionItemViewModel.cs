using TechStoreApp.Infrastructure.Data.EnumTypes;

namespace TechStoreApp.Models.Components;

public class SessionItemViewModel
{
	public Guid ProductId { get; set; }

	public string Name { get; set; } = null!;

	public string Price { get; set; } = null!;

	public string PriceForAll { get; set; } = null!;

	public string Slug { get; set; } = null!;

	public string ImageUrl { get; set; } = null!;

	public int Quantity { get; set; }

	public SessionStatus Status { get; set; }
}
