using TechStoreApp.Core.Models;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.ViewModels.Pages;

public class ProductIndexPageViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];
	public ProductQueryParamsDTO Query { get; set; } = null!;
}
