using TechStoreApp.Core.Models;

namespace TechStoreApp.Core.Contracts;
public interface ICategoryService
{
	Task<List<CategoryDTO>> All(int take, int skip);
	Task<int> Count();
	Task<string?> GetDbName(string categoryName);
	Task<bool> ExistsByName(string categoryName);
}
