namespace TechStoreApp.ViewModels.Components;

public class ProductDetailsTopViewModel
{
	public string Name { get; set; } = null!;
	public string Description { get; set; } = null!;
	public string Price { get; set; } = null!;
	public List<ProductDetailsCategoriesViewModel> Categories { get; set; } = [];
}
