using TechStoreApp.Core.Models.Components;
using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.ViewModels.Components;

namespace TechStoreApp.Contracts;
public interface IUIService
{
	Task<List<BreadcrumbItemViewModel>> ConstructProductsPageBreadcrumb(ProductQueryParamsDTO query);
	Task<List<BreadcrumbItemViewModel>> ConstructProductDetailsPageBreadcrumb(string slug);
	List<BreadcrumbItemViewModel> ConstructCategoriesPageBreadcrumb();
	Task<ProductPaginationViewModel> ConstructProductPagination(int page, int perPage, int totalCount);
}
