using Microsoft.AspNetCore.Identity;

namespace TechStoreApp.Infrastructure.Data.Entities;

public class AppUser : IdentityUser<Guid>
{
	public override string ToString()
	{
		return this.Email;
	}
}
