using System.ComponentModel.DataAnnotations;
using TechStoreApp.Core.Validation;
using TechStoreApp.Infrastructure.Data.EnumTypes;

namespace TechStoreApp.Core.Models.Params.Wishlist;

public class SessionChangeQuantityParams
{
	[NotDefault]
	public Guid ProductId { get; set; }

	[Required]
	[Range(1, int.MaxValue)]
	public int NewQuantity { get; set; }

	[Required]
	public SessionStatus Status { get; set; }
}
