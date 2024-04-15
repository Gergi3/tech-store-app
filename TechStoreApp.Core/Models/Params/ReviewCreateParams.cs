using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Core.Models.Params;

public class ReviewCreateParams
{
	[Required]
	public Guid ProductsId { get; set; }

	[Required]
	public string Text { get; set; } = null!;

	[Required]
	[Range(1, 5)]
	public int Stars { get; set; }

	public bool IsReviewed { get; set; }
}
