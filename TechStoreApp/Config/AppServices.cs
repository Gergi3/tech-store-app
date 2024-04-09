using TechStoreApp.Contracts;
using TechStoreApp.Core.Contracts;
using TechStoreApp.Core.Services;
using TechStoreApp.Infrastructure.Data.Common;
using TechStoreApp.Services;

namespace TechStoreApp.Config;

public static class AppServices
{
	public static IServiceCollection AddAppServices(
		this IServiceCollection services)
	{
		services.AddScoped<IRepository, Repository>();
		services.AddScoped<ICategoryService, CategoryService>();
		services.AddScoped<IProductService, ProductService>();
		services.AddScoped<IWishlistService, WishlistService>();
		services.AddScoped<IUIService, UIService>();

		return services;
	}
}
