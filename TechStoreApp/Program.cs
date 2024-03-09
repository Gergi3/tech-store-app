using DotNetEd.CoreAdmin;
using Microsoft.AspNetCore.Identity;
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

builder.Services.AddCoreAdmin(new CoreAdminOptions()
{
	IgnoreEntityTypes = new List<Type>()
	{
		typeof(IdentityUserClaim<Guid>),
		typeof(IdentityUserRole<Guid>),
		typeof(IdentityUserLogin<Guid>),
		typeof(IdentityRoleClaim<Guid>),
		typeof(IdentityUserToken<Guid>)
	},
	//RestrictToRoles = ["Admin"]
});

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

app.UseCoreAdminCustomTitle("Tech Store CMS");

app.UseRouting();
app.UseCoreAdminCustomUrl("admin");

app.UseAuthorization();

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
