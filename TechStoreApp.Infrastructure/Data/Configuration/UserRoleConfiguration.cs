using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Common;

namespace TechStoreApp.Infrastructure.Data.Configuration;
public class UserRoleConfiguration
	: IEntityTypeConfiguration<IdentityUserRole<Guid>>
{
	public void Configure(
		EntityTypeBuilder<IdentityUserRole<Guid>> builder)
	{
		builder.HasData(this.Seed());
	}

	public IdentityUserRole<Guid> Seed()
	{
		var userRole = new IdentityUserRole<Guid>()
		{
			RoleId = new Guid(DataConstants.User.AdminRoleId),
			UserId = new Guid(DataConstants.User.AdminId)
		};

		return userRole;
	}
}
