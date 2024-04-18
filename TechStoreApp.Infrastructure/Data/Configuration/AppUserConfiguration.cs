using System.Globalization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Entities;
using static TechStoreApp.Common.SeedConstants.User;

namespace TechStoreApp.Infrastructure.Data.Configuration;

public class AppUserConfiguration
	: IEntityTypeConfiguration<AppUser>
{
	public void Configure(
		EntityTypeBuilder<AppUser> builder)
	{
		builder.HasData(this.Seed());
	}

	public List<AppUser> Seed()
	{
		var users = new List<AppUser>();
		var hasher = new PasswordHasher<AppUser>();

		var adminId = new Guid(AdminId);
		var user = new AppUser()
		{
			Id = adminId,
			Email = "admin@mail.com",
			NormalizedEmail = "admin@mail.com".Normalize(),
			UserName = "Administrator",
			NormalizedUserName = "Administrator".Normalize(),
			EmailConfirmed = true,
			PhoneNumberConfirmed = true,
			PhoneNumber = "0894357237",
			SecurityStamp = adminId.ToString("D")
		};

		user.PasswordHash = hasher.HashPassword(user, "Admin.123");
		users.Add(user);

		string[] names = [
			"EmilyJohnson", "JacobSmith", "SophiaBrown", "EthanDavis", "OliviaMartinez",
			"LiamAnderson", "AvaWilson", "NoahTaylor", "IsabellaThomas", "MasonClark",
			"MiaRodriguez", "WilliamLewis", "CharlotteLee", "JamesWalker", "AmeliaHall"
		];

		for (int i = 1; i <= names.Length; i++)
		{
			var id = new Guid($"00000000-0000-0000-0000-{i.ToString("000000000000", CultureInfo.InvariantCulture)}");
			var reviewer = new AppUser()
			{
				Id = id,
				Email = $"reviewer{i}@mail.com",
				NormalizedEmail = $"REVIEWER{i}@MAIL.COM",
				UserName = names[i - 1],
				NormalizedUserName = names[i - 1],
				EmailConfirmed = true,
				PhoneNumberConfirmed = true,
				SecurityStamp = id.ToString("D")
			};
			reviewer.PasswordHash = hasher.HashPassword(reviewer, "Reviewer.123");
			users.Add(reviewer);
		}

		return users;
	}
}
