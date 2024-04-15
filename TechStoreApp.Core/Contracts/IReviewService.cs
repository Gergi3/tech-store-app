using TechStoreApp.Core.Models.DTOs;
using TechStoreApp.Core.Models.Params;

namespace TechStoreApp.Core.Contracts;
public interface IReviewService
{
	Task<ReviewDTO> Create(
		ReviewCreateParams query,
		Guid userId);

	Task<bool> Exists(
		Guid userId,
		Guid productsId);
}
