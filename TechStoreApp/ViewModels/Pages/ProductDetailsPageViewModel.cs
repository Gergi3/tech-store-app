using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.ViewModels.Pages;

public class ProductDetailsPageViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];
	public string Slug { get; set; } = null!;
}
