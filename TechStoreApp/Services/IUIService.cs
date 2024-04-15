using TechStoreApp.Infrastructure.Data.EnumTypes;
using TechStoreApp.Models.Components;

namespace TechStoreApp.Contracts;

public interface IUIService
{
	Task<List<BreadcrumbItemViewModel>> CreateShopPageBreadcrumb(
		string? categorySlug);

	Task<List<BreadcrumbItemViewModel>> CreateProductDetailsPageBreadcrumb(
		string slug);

	List<BreadcrumbItemViewModel> CreateCategoriesPageBreadcrumb();

	ProductPaginationViewModel CreateProductPagination(
		int page,
		int perPage,
		int totalCount);

	List<BreadcrumbItemViewModel> CreateSessionBreadcrumb(SessionStatus status);
}
