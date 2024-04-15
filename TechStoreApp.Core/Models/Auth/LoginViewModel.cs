using System.ComponentModel.DataAnnotations;

namespace TechStoreApp.Core.Models.Auth;
public class LoginViewModel
{

	[Required]
	public string Email { get; set; } = null!;

	[Required]
	public string Password { get; set; } = null!;

	public bool RememberMe { get; set; } = true;

	public string ReturnUrl { get; set; } = "/Home";
}
