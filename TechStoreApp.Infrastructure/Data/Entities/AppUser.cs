using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TechStoreApp.Infrastructure.Data.Configuration;

namespace TechStoreApp.Infrastructure.Data.Entities;

[EntityTypeConfiguration(typeof(AppUserConfiguration))]
public class AppUser : IdentityUser<Guid>
{
}
