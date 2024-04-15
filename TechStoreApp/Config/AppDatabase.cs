using Microsoft.EntityFrameworkCore;
using TechStoreApp.Data;
using static TechStoreApp.Common.ConfigConstants;

namespace TechStoreApp.Config;

public static class AppDatabase
{
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
}
