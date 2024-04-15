namespace TechStoreApp.Models.Components;

public class ProductDetailsBottomViewModel
{
	public List<ExtraInfoViewModel> ExtraInfoItems { get; set; } = [];

	public List<ReviewViewModel> ReviewItems { get; set; } = [];

	public double AverageRating { get; set; }

	public Guid ProductId { get; set; }

	public bool IsReviewed { get; set; }
}
