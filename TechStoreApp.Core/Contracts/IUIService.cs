using TechStoreApp.Core.Models;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Core.Contracts;
public interface IUIService
{
	Task<List<BreadcrumbItemViewModel>> ConstructProductsPageBreadcrumb(ProductQueryParamsDTO query);
	List<BreadcrumbItemViewModel> ConstructCategoriesPageBreadcrumb();
}
