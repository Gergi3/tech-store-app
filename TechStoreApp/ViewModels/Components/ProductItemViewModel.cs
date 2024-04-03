namespace TechStoreApp.ViewModels.Components;

public class ProductItemViewModel
{
	public Guid Id { get; set; }
	public string Name { get; set; } = null!;
	public string Price { get; set; } = null!;
	public bool IsWishlisted { get; set; }
	public string Slug { get; set; } = null!;
	public List<ProductItemCategoriesViewModel> Categories { get; set; } = [];

	//[Required]
	//public int Stars { get; set; }

	//[Required]
	//public int Reviews { get; set; }
}
