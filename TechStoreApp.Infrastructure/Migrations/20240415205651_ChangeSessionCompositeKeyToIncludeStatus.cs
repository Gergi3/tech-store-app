using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class ChangeSessionCompositeKeyToIncludeStatus : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropPrimaryKey(
			name: "PK_Sessions",
			table: "Sessions");

		migrationBuilder.AddPrimaryKey(
			name: "PK_Sessions",
			table: "Sessions",
			columns: new[] { "ProductId", "UserId", "Status" });
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropPrimaryKey(
			name: "PK_Sessions",
			table: "Sessions");

		migrationBuilder.AddPrimaryKey(
			name: "PK_Sessions",
			table: "Sessions",
			columns: new[] { "ProductId", "UserId" });
	}
}
