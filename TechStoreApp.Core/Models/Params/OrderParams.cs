using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Core.Models.Params;

public class OrderParams
{
	[Required]
	public string FirstName { get; set; } = null!;

	[Required]
	public string LastName { get; set; } = null!;

	public string? CompanyName { get; set; }

	[Required]
	public string Country { get; set; } = null!;

	[Required]
	public string City { get; set; } = null!;

	[Required]
	public string Address { get; set; } = null!;

	[Required]
	[DataType(DataType.PhoneNumber)]
	public string Phone { get; set; } = null!;

	public string? OrderNotes { get; set; }
}
