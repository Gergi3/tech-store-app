using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Core.Models.Components;
public class CategoryListItemViewModel
{
	[Required]
	public string Name { get; set; }

	[Required]
	public Guid Id { get; set; }

	[Required]
	public int Count { get; set; }
}
