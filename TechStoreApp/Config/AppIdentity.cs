using TechStoreApp.Data;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Config;

public static class AppIdentity
{
	public static IServiceCollection AddAppIdentity(
		this IServiceCollection services)
	{
		services.AddDefaultIdentity<AppUser>(
			options => options.SignIn.RequireConfirmedAccount = true)
			.AddEntityFrameworkStores<TechStoreDbContext>();

		return services;
	}
}
