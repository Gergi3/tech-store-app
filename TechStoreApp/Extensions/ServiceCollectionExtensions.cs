using DotNetEd.CoreAdmin;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Services;
using TechStoreApp.Data;
using TechStoreApp.Infrastructure.Data.Entities;
using static TechStoreApp.Common.ConfigConstants;

namespace TechStoreApp.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddAppServices(this IServiceCollection services)
	{
		services.AddScoped<ICategoryService, CategoryService>();
		services.AddScoped<IProductService, ProductService>();

		return services;
	}

	public static IServiceCollection AddAppDatabase(
		this IServiceCollection services,
		ConfigurationManager configuration)
	{
		var connectionString = configuration.GetConnectionString(ConnectionStringName)
			?? throw new InvalidOperationException($"Connection string {ConnectionStringName} not found.");

		services.AddDbContext<TechStoreDbContext>(
			options => options.UseSqlServer(connectionString));

		services.AddDatabaseDeveloperPageExceptionFilter();

		return services;
	}

	public static IServiceCollection AddAppIdentity(this IServiceCollection services)
	{
		services.AddDefaultIdentity<AppUser>(
			options => options.SignIn.RequireConfirmedAccount = true)
			.AddEntityFrameworkStores<TechStoreDbContext>();

		return services;
	}

	public static IServiceCollection AddAppMVC(this IServiceCollection services)
	{
		services.AddControllersWithViews()
			.AddRazorOptions(options =>
			{
				options.ViewLocationFormats.Add(AdditionalViewLocationFormat);
			});
		return services;
	}

	public static IServiceCollection AddAppMVCRouting(this IServiceCollection services)
	{
		services.AddRouting(
			options => options.LowercaseUrls = true);

		return services;
	}

	public static IServiceCollection AddAppCoreAdmin(this IServiceCollection services)
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
			//RestrictToRoles = ["Admin"]
		});

		return services;
	}
}
