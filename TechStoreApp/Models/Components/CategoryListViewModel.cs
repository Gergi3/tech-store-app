namespace TechStoreApp.Models.Components;

public class CategoryListViewModel
{
	public ICollection<CategoryItemViewModel> Items { get; set; } = [];

	public int TotalCount { get; set; }

	public int Take { get; set; }

	public int Skip { get; set; }

	public bool Layout { get; set; }
}
