using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
	{ }

	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<ProductCategory> ProductCategory { get; set; }
	public DbSet<Wishlist> Wishlist { get; set; }
	public DbSet<ExtraInfo> ExtraInfos { get; set; }
	public DbSet<Review> Reviews { get; set; }
	public DbSet<CartItem> CartItems { get; set; }
}
