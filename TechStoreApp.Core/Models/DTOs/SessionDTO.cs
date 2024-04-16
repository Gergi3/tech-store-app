using TechStoreApp.Infrastructure.Data.EnumTypes;

namespace TechStoreApp.Core.Models.DTOs;

public class SessionDTO
{
	public Guid ProductId { get; set; }

	public string Name { get; set; } = null!;

	public decimal Price { get; set; }

	public string Slug { get; set; } = null!;

	public int Quantity { get; set; }

	public string ImageUrl { get; set; } = null!;

	public SessionStatus Status { get; set; }
}
