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
		services.AddScoped<IAccountService, AccountService>();
		services.AddScoped<ICategoryService, CategoryService>();
		services.AddScoped<IProductService, ProductService>();
		services.AddScoped<ISessionService, SessionService>();
		services.AddScoped<IReviewService, ReviewService>();
		services.AddScoped<IUIService, UIService>();

		return services;
	}
}
