using TechStoreApp.Core.Models;
using TechStoreApp.Core.Models.Components;

namespace TechStoreApp.Core.Contracts;

public interface IProductService
{
	Task<List<ProductDTO>> All(ProductQueryParamsDTO query);
	Task<List<BreadcrumbItemViewModel>> ConstructBreadcrumb(ProductQueryParamsDTO query);
}
