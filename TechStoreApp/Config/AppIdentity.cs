using Microsoft.AspNetCore.Identity;
using TechStoreApp.Data;
using TechStoreApp.Infrastructure.Data.Entities;
using static TechStoreApp.Common.DataConstants.User;

namespace TechStoreApp.Config;

public static class AppIdentity
{
	public static IServiceCollection AddAppIdentity(
		this IServiceCollection services)
	{
		services.AddDefaultIdentity<AppUser>(
			options =>
			{
				options.User.RequireUniqueEmail = RequireUniqueEmail;

				options.SignIn = new SignInOptions
				{
					RequireConfirmedAccount = RequireConfirmedAccount,
					RequireConfirmedPhoneNumber = RequireConfirmedPhoneNumber,
					RequireConfirmedEmail = RequireConfirmedEmail
				};

				options.Password = new PasswordOptions()
				{
					RequiredLength = MinPasswordLength,
					RequiredUniqueChars = 0,
					RequireUppercase = RequireUppercase,
					RequireLowercase = RequireLowercase,
					RequireNonAlphanumeric = RequireNonAlphanumeric,
					RequireDigit = RequireDigit
				};
			})
			.AddEntityFrameworkStores<TechStoreDbContext>();

		services.ConfigureApplicationCookie(options =>
		{
			options.LoginPath = "/account/login";
		});

		return services;
	}
}
