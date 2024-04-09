namespace TechStoreApp.Config;

public static class AppRouting
{
	public static IServiceCollection AddAppMVCRouting(
		this IServiceCollection services)
	{
		services.AddRouting(
			options =>
			{
				options.ConstraintMap.Add("slugify", typeof(SlugifyEndpointsTransformer));
				options.LowercaseUrls = true;
			});

		return services;
	}
}
