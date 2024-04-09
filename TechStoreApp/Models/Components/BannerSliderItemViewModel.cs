using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Models.Components;

public class BannerSliderItemViewModel
{
	[Required]
	public string Title { get; set; } = null!;

	[Required]
	public string Text { get; set; } = null!;

	[Required]
	public string SecondaryText { get; set; } = null!;

	[Required]
	public Guid ProductId { get; set; }
}
