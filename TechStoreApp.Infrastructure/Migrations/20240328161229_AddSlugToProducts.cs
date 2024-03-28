using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class AddSlugToProducts : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.AddColumn<string>(
			name: "Slug",
			table: "Products",
			type: "nvarchar(200)",
			maxLength: 200,
			nullable: false,
			defaultValue: "");

		migrationBuilder.Sql(
			@"UPDATE Products SET Slug = Concat('slug-', Id)"
		);

		migrationBuilder.CreateIndex(
			name: "IX_Products_Name",
			table: "Products",
			column: "Name",
			unique: true);

		migrationBuilder.CreateIndex(
			name: "IX_Products_Slug",
			table: "Products",
			column: "Slug",
			unique: true);
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropIndex(
			name: "IX_Products_Name",
			table: "Products");

		migrationBuilder.DropIndex(
			name: "IX_Products_Slug",
			table: "Products");

		migrationBuilder.DropColumn(
			name: "Slug",
			table: "Products");
	}
}
