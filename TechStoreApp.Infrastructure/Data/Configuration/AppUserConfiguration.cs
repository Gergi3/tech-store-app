using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Common;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;

public class AppUserConfiguration
	: IEntityTypeConfiguration<AppUser>
{
	public void Configure(
		EntityTypeBuilder<AppUser> builder)
	{
		builder.HasData(this.Seed());
	}

	public AppUser Seed()
	{
		var hasher = new PasswordHasher<AppUser>();

		var user = new AppUser()
		{
			Id = new Guid(DataConstants.User.AdminId),
			Email = "admin@mail.com",
			NormalizedEmail = "admin@mail.com".Normalize(),
			UserName = "Administrator",
			NormalizedUserName = "Administrator".Normalize(),
			EmailConfirmed = true,
			PhoneNumberConfirmed = true,
			PhoneNumber = "0894357237",
			SecurityStamp = Guid.NewGuid().ToString("D")
		};

		user.PasswordHash = hasher.HashPassword(user, "Admin.123");

		return user;
	}
}
