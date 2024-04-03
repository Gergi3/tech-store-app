using TechStoreApp.Core.Models.DTOs;

namespace TechStoreApp.Core.Contracts;
public interface ICategoryService
{
	Task<List<CategoryDTO>> All(CategoryQueryParamsDTO query);
	Task<int> Count();
	Task<string?> GetNameBySlug(string categorySlug);
}
