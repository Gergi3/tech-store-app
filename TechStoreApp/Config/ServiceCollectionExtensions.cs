using DotNetEd.CoreAdmin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Common.Exceptions;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Mappers;
using TechStoreApp.Core.Services;
using TechStoreApp.Data;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Infrastructure.Data.Entities;
using TechStoreApp.Mappers;
using static TechStoreApp.Common.ConfigConstants;

namespace TechStoreApp.Config;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddAppServices(this IServiceCollection services)
	{
		services.AddScoped<IRepository, Repository>();
		services.AddScoped<ICategoryService, CategoryService>();
		services.AddScoped<IProductService, ProductService>();
		services.AddScoped<IWishlistService, WishlistService>();
		services.AddScoped<IUIService, UIService>();

		return services;
	}

	public static IServiceCollection AddAppAutoMapper(this IServiceCollection services)
	{
		services.AddAutoMapper(
			configAction: (cfg) =>
			{
				cfg.AddProfile<CategoryProfile>();
				cfg.AddProfile<ProductProfile>();
				cfg.AddProfile<WishlistProfile>();
				cfg.AddProfile<ViewComponentsProfile>();
			},
			assemblies: typeof(Program).Assembly);

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
		services
			.AddControllersWithViews()
			.AddRazorOptions(options =>
			{
				foreach (var item in AdditionalViewLocationFormats)
				{
					options.ViewLocationFormats.Add(item + RazorViewEngine.ViewExtension);
				}
			});

		return services;
	}

	public static IServiceCollection AddAppMVCRouting(this IServiceCollection services)
	{
		services.AddRouting(
			options =>
			{
				options.ConstraintMap.Add("slugify", typeof(SlugifyEndpointsTransformer));
				options.LowercaseUrls = true;
			});

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

	public static IServiceCollection AddAppCors(
		this IServiceCollection services,
		ConfigurationManager configuration)
	{
		string? host = configuration.GetSection(HostName).Value;

		if (host == null)
		{
			throw new AppHostNotFoundException();
		}

		services.AddCors(opt =>
		{
			opt.AddPolicy("AllowSpecificOrigins",
				policy =>
				{
					policy.WithOrigins(host);
				});
		});

		return services;
	}
}
