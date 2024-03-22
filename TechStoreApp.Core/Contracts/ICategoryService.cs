using TechStoreApp.Core.Models;

namespace TechStoreApp.Core.Contracts;
public interface ICategoryService
{
	Task<List<CategoryDTO>> All(int count, int skip);
	Task<int> Count();
}
