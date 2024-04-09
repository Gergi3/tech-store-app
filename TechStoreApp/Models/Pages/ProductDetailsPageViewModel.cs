using TechStoreApp.Models.Components;

namespace TechStoreApp.Models.Pages;

public class ProductDetailsPageViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];

	public string Slug { get; set; } = null!;

	public Guid CurrentUserId { get; set; }
}
