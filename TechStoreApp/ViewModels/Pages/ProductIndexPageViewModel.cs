using TechStoreApp.Core.Models.Components;
using TechStoreApp.Core.Models.DTOs;

namespace TechStoreApp.ViewModels.Pages;

public class ProductIndexPageViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];
	public ProductQueryParamsDTO Query { get; set; } = null!;
}
