using TechStoreApp.Core.Mappers;
using TechStoreApp.Mappers;

namespace TechStoreApp.Config;

public static class AppAutoMapper
{
	public static IServiceCollection AddAppAutoMapper(
		this IServiceCollection services)
	{
		services.AddAutoMapper(
			configAction: (cfg) =>
			{
				cfg.AddProfile<CategoryProfile>();
				cfg.AddProfile<ProductProfile>();
				cfg.AddProfile<WishlistProfile>();
				cfg.AddProfile<ExtraInfoProfile>();
				cfg.AddProfile<ReviewProfile>();
				cfg.AddProfile<ViewComponentsProfile>();
			},
			assemblies: typeof(Program).Assembly);

		return services;
	}

}
