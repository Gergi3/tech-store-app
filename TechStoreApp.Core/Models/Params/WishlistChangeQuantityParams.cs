using System.ComponentModel.DataAnnotations;
using TechStoreApp.Core.Validation;

namespace TechStoreApp.Core.Models.Params.Wishlist;

public class WishlistChangeQuantityParams
{
	[NotDefault]
	public Guid ProductId { get; set; }

	[Required]
	[Range(1, int.MaxValue)]
	public int NewQuantity { get; set; }
}
