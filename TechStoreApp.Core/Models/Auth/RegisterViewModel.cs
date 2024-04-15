using System.ComponentModel.DataAnnotations;
using static TechStoreApp.Common.DataConstants.User;

namespace TechStoreApp.Core.Models.Auth;
public class RegisterViewModel
{
	[Required]
	[RegularExpression(
		UserNameRegex,
		ErrorMessage = UserNameErrorMessage)]
	public string UserName { get; set; } = null!;

	[Required]
	[EmailAddress]
	public string Email { get; set; } = null!;

	[Required]
	[DataType(DataType.Password)]
	[StringLength(
		MaxPasswordLength,
		MinimumLength = MinPasswordLength)]
	[RegularExpression(
		PasswordRegex,
		ErrorMessage = PasswordRegexErrorMessage)]
	public string Password { get; set; } = null!;

	[Required]
	[Compare(nameof(Password))]
	public string RepeatPassword { get; set; } = null!;


	public string ReturnUrl { get; set; } = "/Home";
}
