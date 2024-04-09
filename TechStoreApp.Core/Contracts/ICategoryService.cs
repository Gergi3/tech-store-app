using TechStoreApp.Core.Models.DTOs;

namespace TechStoreApp.Core.Contracts;

public interface ICategoryService
{
	Task<List<CategoryDTO>> All(
		int skip,
		int take);

	Task<int> Count();

	Task<string?> GetNameBySlug(
		string categorySlug);

	Task<bool> TryExists(
		string? categorySlug);
}
