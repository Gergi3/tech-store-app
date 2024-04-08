namespace TechStoreApp.ViewModels.Components;

public class ProductDetailsTopViewModel
{
	public Guid Id { get; set; }
	public string Name { get; set; } = null!;
	public string Description { get; set; } = null!;
	public string Price { get; set; } = null!;
	public bool IsWishlisted { get; set; }
	public List<ProductDetailsCategoriesViewModel> Categories { get; set; } = [];
}