using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Core.Models.DTOs;

public class ProductQueryParamsDTO
{
	public string? CategorySlug { get; set; }

	[Required]
	public int Page { get; set; }

	[Required]
	public int PerPage { get; set; }

	[Required]
	public Guid CurrentUserId { get; set; }
}
