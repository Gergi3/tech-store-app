using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;

public class AppUserConfiguration
	: IEntityTypeConfiguration<AppUser>
{
	public void Configure(
		EntityTypeBuilder<AppUser> builder)
	{
	}
}
