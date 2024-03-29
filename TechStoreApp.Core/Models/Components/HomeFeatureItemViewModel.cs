using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Core.Models.Components;
public class HomeFeatureItemViewModel
{
	[Required]
	public string Title { get; set; } = null!;

	[Required]
	public string Text { get; set; } = null!;
}
