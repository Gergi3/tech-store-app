using TechStoreApp.Core.Models.DTOs;

namespace TechStoreApp.Core.Contracts;

public interface IProductService
{
	Task<List<ProductDTO>> All(
		ProductQueryParams query,
		Guid userId);

	Task<int> Count(
		ProductQueryParams query);

	Task<string?> GetNameBySlug(
		string productSlug);

	Task<ProductDTO?> GetBySlug(
		string slug,
		Guid userId);

	Task<Tuple<decimal, decimal>> GetMinAndMax(
		string? categorySlug);

	Task<bool> Exists(
		string slug);

	Task<List<ProductDTO>> TopRated(
		int count);
}
