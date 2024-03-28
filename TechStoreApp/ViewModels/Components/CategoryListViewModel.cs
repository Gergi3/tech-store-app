namespace TechStoreApp.ViewModels.Components;

public class CategoryListViewModel
{
	public ICollection<CategoryItemViewModel> Items { get; set; } = [];
	public int AllCount { get; set; }
	public int Take { get; set; }
	public int Skip { get; set; }
	public bool Layout { get; set; }
}
