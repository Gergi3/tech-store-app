using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Infrastructure.Data.EnumTypes;

namespace TechStoreApp.Core.Contracts;

public interface ISessionService
{
	Task<List<SessionDTO>> GetByUserId(
		Guid userId,
		SessionStatus status);

	Task<bool> ChangeStatus(
		Guid userId,
		Guid productId,
		SessionStatus status);

	Task<int> Count(
		Guid userId,
		SessionStatus status);

	Task<bool> EditQuantity(
		Guid productId,
		Guid currentUserId,
		SessionStatus status,
		int newQuantity);
}
