using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Core.Models.Params;

namespace TechStoreApp.Core.Contracts;

public interface IOrderService
{
	Task Create(
		OrderParams orderParams,
		Guid userId);

	Task<List<OrderDTO>> All(
		Guid userId);
}
