
using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Core.Models.Components;
public class ProductListItemViewModel
{
	[Required]
	public Guid CategoryId { get; set; }

	[Required]
	public string CategoryName { get; set; } = null!;

	[Required]
	public Guid ProductId { get; set; }

	[Required]
	public string ProductName { get; set; } = null!;

	[Required]
	public decimal Price { get; set; }

	[Required]
	public int Stars { get; set; }

	[Required]
	public int Reviews { get; set; }
}
