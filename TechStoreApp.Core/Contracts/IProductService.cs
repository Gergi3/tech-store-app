using TechStoreApp.Core.Models;

namespace TechStoreApp.Core.Contracts;

public interface IProductService
{
	Task<List<ProductDTO>> All(ProductQueryParamsDTO query);
	Task<int> Count(ProductQueryParamsDTO query);
}
