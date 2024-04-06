using TechStoreApp.Core.Models.DTOs;

namespace TechStoreApp.Core.Contracts;

public interface IProductService
{
	Task<List<ProductDTO>> All(ProductQueryParamsDTO query);
	Task<int> Count(ProductQueryParamsDTO query);
	Task<string?> GetNameBySlug(string productSlug);
	Task<ProductDTO?> GetBySlug(string slug);
	Task<Tuple<decimal, decimal>> GetMinAndMax(ProductQueryParamsDTO query);
}
