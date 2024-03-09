using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Core.Models.Components;
public class StarRatingViewModel
{
	[Required]
	public int Stars { get; set; }

	[Required]
	public int Reviews { get; set; }
}
