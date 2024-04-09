using Microsoft.AspNetCore.Mvc.Razor;
using static TechStoreApp.Common.ConfigConstants;

namespace TechStoreApp.Config;

public static class AppMVC
{
	public static IServiceCollection AddAppMVC(
		this IServiceCollection services)
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
}
