using static TechStoreApp.Common.ConfigConstants;

namespace TechStoreApp.Extensions;

public static class AppExtension
{
	public static WebApplication ConfigurePipeline(this WebApplication app)
	{
		if (app.Environment.IsDevelopment())
		{
			app.UseDeveloperExceptionPage();
			app.UseMigrationsEndPoint();
		}
		else
		{
			app.UseExceptionHandler(ErrorHandlerPageRoute);
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseCoreAdminCustomTitle(CoreAdminTitle);

		app.UseRouting();

		app.UseAuthorization();

		app.MapDefaultControllerRoute();
		app.UseCoreAdminCustomUrl(CoreAdminUrl);
		app.MapRazorPages();

		return app;
	}
}
