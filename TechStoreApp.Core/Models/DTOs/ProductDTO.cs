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

	public string? Description { get; set; }

	[Required]
	public decimal Price { get; set; }

	public string ImageUrl { get; set; } = null!;

	public double AverageRating { get; set; }

	public int ReviewsCount { get; set; }


	public bool IsWishlisted { get; set; }
	public bool IsInCart { get; set; }

	public List<CategoryDTO> Categories { get; set; } = [];
	public List<ExtraInfoDTO> ExtraInfos { get; set; } = [];
	public List<ReviewDTO> Reviews { get; set; } = [];
}
