using TechStoreApp.Core.Models.Params;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Models.Pages;

public class CategoryIndexPageViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];

	public CategoryQueryParams Query { get; set; } = null!;
}
