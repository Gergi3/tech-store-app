using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class RemoveUserImageUrl : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropColumn(
			name: "ImageUrl",
			table: "AspNetUsers");
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.AddColumn<string>(
			name: "ImageUrl",
			table: "AspNetUsers",
			type: "nvarchar(max)",
			nullable: false,
			defaultValue: "/img/profile-default.png");
	}
}
