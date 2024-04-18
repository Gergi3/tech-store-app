using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data.Configuration;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Data;

public class TechStoreDbContext
	: IdentityDbContext<
		AppUser,
		IdentityRole<Guid>,
		Guid,
		IdentityUserClaim<Guid>,
		IdentityUserRole<Guid>,
		IdentityUserLogin<Guid>,
		IdentityRoleClaim<Guid>,
		IdentityUserToken<Guid>>
{
	public TechStoreDbContext(
		DbContextOptions<TechStoreDbContext> options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.ApplyConfiguration(new AppUserConfiguration());
		builder.ApplyConfiguration(new RoleConfiguration());
		builder.ApplyConfiguration(new UserRoleConfiguration());
		builder.ApplyConfiguration(new ProductConfiguration());
		builder.ApplyConfiguration(new CategoryConfiguration());
		builder.ApplyConfiguration(new ProductCategoryConfiguration());
		builder.ApplyConfiguration(new ReviewConfiguration());

		base.OnModelCreating(builder);
	}

	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<ProductCategory> ProductCategory { get; set; }
	public DbSet<Session> Sessions { get; set; }
	public DbSet<ExtraInfo> ExtraInfos { get; set; }
	public DbSet<Review> Reviews { get; set; }
	public DbSet<Order> Orders { get; set; }
	public DbSet<OrderProduct> OrderProduct { get; set; }
}
