using Microsoft.EntityFrameworkCore;
using TechStoreApp.Data;
using TechStoreApp.Infrastructure.Data.Entities;
using static TechStoreApp.Common.ConfigConstants;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString(ConnectionStringName)
	?? throw new InvalidOperationException($"Connection string {ConnectionStringName} not found.");

builder.Services.AddDbContext<TechStoreDbContext>(
	options => options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<AppUser>(
	options => options.SignIn.RequireConfirmedAccount = true)
	.AddEntityFrameworkStores<TechStoreDbContext>();

builder.Services.AddControllersWithViews()
	.AddRazorOptions(options =>
	{
		options.ViewLocationFormats.Add(AdditionalViewLocationFormat);
	});

builder.Services.AddRouting(
	options => options.LowercaseUrls = true);

var app = builder.Build();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
