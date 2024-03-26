using static TechStoreApp.Common.ConfigConstants;

namespace TechStoreApp.Config;

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

		app.UseCors("AllowSpecificOrigins");

		app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller:slugify=Home}/{action:slugify=Index}/{id?}");

		app.MapControllerRoute(
			name: "products",
			pattern: "categories/{categorySlug}/products",
			defaults: new { controller = "Products", action = "Index" }
		);

		app.UseCoreAdminCustomUrl(CoreAdminUrl);
		app.MapRazorPages();

		return app;
	}
}
