using System.ComponentModel.DataAnnotations;
using static TechStoreApp.Common.DataConstants.Category;

namespace TechStoreApp.Core.Models.DTOs;

public class CategoryDTO
{
	public Guid Id { get; set; }

	[Required]
	[StringLength(MaxNameLength, MinimumLength = MinNameLength)]
	public string Name { get; set; } = null!;

	[Required]
	[StringLength(MaxNameLength, MinimumLength = MinNameLength)]
	public string Slug { get; set; } = null!;

	public int Count { get; set; }
}
