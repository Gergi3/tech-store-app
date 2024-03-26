using System.ComponentModel.DataAnnotations;
using static TechStoreApp.Common.DataConstants.Category;

namespace TechStoreApp.Core.Models;
public class CategoryDTO
{
	public Guid Id { get; set; }

	[Required]
	[StringLength(MaxNameLength, MinimumLength = MinNameLength)]
	public string Name { get; set; } = null!;

	[StringLength(MaxNameLength, MinimumLength = MinNameLength)]
	public string? Slug { get; set; }

	public int Count { get; set; }
}