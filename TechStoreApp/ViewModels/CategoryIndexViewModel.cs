using TechStoreApp.Core.Models;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.ViewModels;

public class CategoryIndexViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];
	public CategoryQueryParamsDTO Query { get; set; } = null!;
}
