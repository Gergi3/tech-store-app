using TechStoreApp.Core.Models.DTOs;

namespace TechStoreApp.Core.Contracts;

public interface IWishlistService
{
	Task<List<WishlistDTO>> GetByUserId(
		Guid userId);

	Task<bool> ChangeStatus(
		Guid userId,
		Guid productId);

	Task<bool> Exists(
		Guid productId,
		Guid userId);

	Task<int> Count(
		Guid userId);

	Task<bool> EditQuantity(
		Guid productId,
		Guid currentUserId,
		int newQuantity);
}
