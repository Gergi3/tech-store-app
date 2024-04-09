using TechStoreApp.Common.Exceptions;
using static TechStoreApp.Common.ConfigConstants;

namespace TechStoreApp.Config;

public static class AppCors
{
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
