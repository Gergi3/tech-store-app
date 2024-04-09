namespace TechStoreApp.Models.Components;

public class ProductListViewModel
{
	public List<ProductItemViewModel> Items { get; set; } = [];

	public ProductPaginationViewModel Pagination { get; set; } = null!;

	public bool Layout { get; set; }
}
