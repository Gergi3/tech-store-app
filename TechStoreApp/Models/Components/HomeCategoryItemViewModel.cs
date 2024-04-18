namespace TechStoreApp.Models.Components;

public class HomeCategoryItemViewModel
{
	public string Name { get; set; } = null!;

	public string Slug { get; set; } = null!;

	public int Count { get; set; }

	public string ImageUrl { get; set; } = null!;
}
