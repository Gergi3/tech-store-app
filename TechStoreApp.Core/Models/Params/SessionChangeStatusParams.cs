using System.ComponentModel.DataAnnotations;
using TechStoreApp.Core.Validation;
using TechStoreApp.Infrastructure.Data.EnumTypes;

namespace TechStoreApp.Core.Models.Params;

public class SessionChangeStatusParams
{
	[NotDefault]
	public Guid ProductId { get; set; }

	[Required]
	public SessionStatus Status { get; set; }
}
