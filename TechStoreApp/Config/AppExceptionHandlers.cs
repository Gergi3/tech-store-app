using TechStoreApp.Handlers;

namespace TechStoreApp.Config;

public static class AppExceptionHandlers
{
	public static IServiceCollection AddAppExceptionHandlers(
		this IServiceCollection services)
	{
		services.AddExceptionHandler<NotFoundExceptionHandler>();

		return services;
	}
}
