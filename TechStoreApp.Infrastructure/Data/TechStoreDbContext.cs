using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data;
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

	public virtual DbSet<Category> Categories { get; set; }
	public virtual DbSet<Product> Products { get; set; }
	public virtual DbSet<ProductCategory> ProductCategory { get; set; }
	public virtual DbSet<Session> Sessions { get; set; }
	public virtual DbSet<ExtraInfo> ExtraInfos { get; set; }
	public virtual DbSet<Review> Reviews { get; set; }
	public virtual DbSet<Order> Orders { get; set; }
	public virtual DbSet<OrderProduct> OrderProduct { get; set; }
}
