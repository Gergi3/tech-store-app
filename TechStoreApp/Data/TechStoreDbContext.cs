using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TechStoreApp.Data;

public class TechStoreDbContext : IdentityDbContext
{
	public TechStoreDbContext(DbContextOptions<TechStoreDbContext> options)
		: base(options)
	{
	}
}
