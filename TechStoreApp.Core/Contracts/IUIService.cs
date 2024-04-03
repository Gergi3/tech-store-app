using TechStoreApp.Core.Models.Components;
using TechStoreApp.Core.Models.DTOs;

namespace TechStoreApp.Core.Contracts;
public interface IUIService
{
	Task<List<BreadcrumbItemViewModel>> ConstructProductsPageBreadcrumb(ProductQueryParamsDTO query);
	Task<List<BreadcrumbItemViewModel>> ConstructProductDetailsPageBreadcrumb(string slug);
	List<BreadcrumbItemViewModel> ConstructCategoriesPageBreadcrumb();
}
