using System.ComponentModel.DataAnnotations;
using static TechStoreApp.Common.DataConstants.Product;

namespace TechStoreApp.Core.Models;
public class ProductDTO
{
	public Guid Id { get; set; }

	[Required]
	[StringLength(MaxNameLength)]
	public string Name { get; set; } = null!;

	[Required]
	public decimal Price { get; set; }

	public List<CategoryDTO> Categories { get; set; } = [];
}
