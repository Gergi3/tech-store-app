using TechStoreApp.Core.Models.Components;
using TechStoreApp.Core.Models.DTOs;

namespace TechStoreApp.ViewModels.Pages;

public class CategoryIndexPageViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];
	public CategoryQueryParamsDTO Query { get; set; } = null!;
}
