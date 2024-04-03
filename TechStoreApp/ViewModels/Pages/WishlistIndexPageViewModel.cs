using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.ViewModels.Pages;

public class WishlistIndexPageViewModel
{
	public List<BreadcrumbItemViewModel> Breadcrumb { get; set; } = [];
	public Guid CurrentUserId { get; set; }
}
