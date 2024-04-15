using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStoreApp.Infrastructure.Data.Entities;

namespace TechStoreApp.Infrastructure.Data.Configuration;

public class SessionConfiguration
	: IEntityTypeConfiguration<Session>
{
	public void Configure(
		EntityTypeBuilder<Session> builder)
	{
		builder
			.HasKey(s => new { s.ProductId, s.UserId, s.Status });

		builder
			.Property(s => s.Quantity)
			.HasDefaultValue(1);
	}
}
