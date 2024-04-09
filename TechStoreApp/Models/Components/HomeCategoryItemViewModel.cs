using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Models.Components;

public class HomeCategoryItemViewModel
{
	[Required]
	public string Name { get; set; } = null!;

	[Required]
	public int Count { get; set; }

	[Required]
	public Guid CategoryId { get; set; }
}
