namespace TechStoreApp.Components.CategoryList;

public class CategoryItemViewModel
{
	public Guid Id { get; set; }
	public string Name { get; set; } = null!;
	public string Slug { get; set; } = null!;
	public int Count { get; set; }
}
