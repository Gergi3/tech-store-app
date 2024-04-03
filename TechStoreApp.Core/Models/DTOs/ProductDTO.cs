using System.ComponentModel.DataAnnotations;
using static TechStoreApp.Common.DataConstants.Product;

namespace TechStoreApp.Core.Models.DTOs;
public class ProductDTO
{
	public Guid Id { get; set; }

	[Required]
	[StringLength(MaxNameLength, MinimumLength = MinNameLength)]
	public string Name { get; set; } = null!;

	[Required]
	[StringLength(MaxNameLength, MinimumLength = MinNameLength)]
	public string Slug { get; set; } = null!;

	[Required]
	public decimal Price { get; set; }

	public bool IsWishlisted { get; set; }

	public List<CategoryDTO> Categories { get; set; } = [];
}
