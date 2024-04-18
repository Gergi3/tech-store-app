using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Common;

namespace TechStoreApp.Infrastructure.Data.Configuration;
public class RoleConfiguration
	: IEntityTypeConfiguration<IdentityRole<Guid>>
{
	public void Configure(
		EntityTypeBuilder<IdentityRole<Guid>> builder)
	{
		builder.HasData(this.Seed());
	}

	public IdentityRole<Guid> Seed()
	{
		var role = new IdentityRole<Guid>()
		{
			Id = new Guid(DataConstants.User.AdminRoleId),
			Name = DataConstants.User.AdminRole
		};

		return role;
	}
}
