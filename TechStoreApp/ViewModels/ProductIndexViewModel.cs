using TechStoreApp.Core.Models;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.ViewModels;

public class ProductIndexViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];
	public ProductQueryParamsDTO Query { get; set; } = null!;
}
