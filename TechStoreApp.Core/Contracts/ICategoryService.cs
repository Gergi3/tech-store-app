using TechStoreApp.Core.Models;

namespace TechStoreApp.Core.Contracts;
public interface ICategoryService
{
	Task<List<CategoryDTO>> All(int take, int skip);
	Task<int> Count();
	Task<string?> GetDbNameBySlug(string categorySlug);
}
