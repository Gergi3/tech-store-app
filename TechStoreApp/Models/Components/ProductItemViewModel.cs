namespace TechStoreApp.Models.Components;

public class ProductItemViewModel
{
	public Guid Id { get; set; }

	public string Name { get; set; } = null!;

	public string Price { get; set; } = null!;

	public bool IsWishlisted { get; set; }

	public double AverageRating { get; set; }

	public string Slug { get; set; } = null!;

	public List<ProductItemCategoriesViewModel> Categories { get; set; } = [];
}
