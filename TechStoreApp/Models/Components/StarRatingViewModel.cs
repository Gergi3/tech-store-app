using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Models.Components;

public class StarRatingViewModel
{
	[Required]
	public int Stars { get; set; }

	public int? Reviews { get; set; }
}
