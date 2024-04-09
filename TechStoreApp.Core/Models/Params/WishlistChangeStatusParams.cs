using TechStoreApp.Core.Validation;

namespace TechStoreApp.Core.Models.Params;

public class WishlistChangeStatusParams
{
	[NotDefault]
	public Guid ProductId { get; set; }
}
