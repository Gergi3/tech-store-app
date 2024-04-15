using TechStoreApp.Infrastructure.Data.EnumTypes;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Models.Pages;

public class SessionIndexPageViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];
	public SessionStatus Status { get; set; }
}
