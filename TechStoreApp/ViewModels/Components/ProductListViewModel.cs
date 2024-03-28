namespace TechStoreApp.ViewModels.Components;

public class ProductListViewModel
{
	public List<ProductItemViewModel> Items { get; set; } = [];
	public int Page { get; set; }
	public int PerPage { get; set; }
	public int AllCount { get; set; }
	public bool Layout { get; set; }
}
