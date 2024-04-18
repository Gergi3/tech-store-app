using DotNetEd.CoreAdmin;
using Microsoft.AspNetCore.Identity;
using static TechStoreApp.Common.DataConstants.User;

namespace TechStoreApp.Config;

public static class AppCoreAdmin
{
	public static IServiceCollection AddAppCoreAdmin(
		this IServiceCollection services)
	{
		services.AddCoreAdmin(new CoreAdminOptions()
		{
			IgnoreEntityTypes = new List<Type>()
			{
				typeof(IdentityUserClaim<Guid>),
				typeof(IdentityUserRole<Guid>),
				typeof(IdentityUserLogin<Guid>),
				typeof(IdentityRoleClaim<Guid>),
				typeof(IdentityUserToken<Guid>)
			},
			RestrictToRoles = [AdminRole],
		});

		return services;
	}
}
