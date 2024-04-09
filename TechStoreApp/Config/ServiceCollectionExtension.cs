namespace TechStoreApp.Config;

public static class ServiceCollectionExtension
{
	public static IServiceCollection AddServices(
		this IServiceCollection services,
		ConfigurationManager configurationManager)
	{
		return services.AddAppDatabase(configurationManager)
				.AddAppIdentity()
				.AddAppMVC()
				.AddAppMVCRouting()
				.AddAppCoreAdmin()
				.AddAppServices()
				.AddAppAutoMapper()
				.AddAppCors(configurationManager)
				.AddAppExceptionHandlers();
	}

}
