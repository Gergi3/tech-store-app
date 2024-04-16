using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class AddImageUrlsToUserProductsCategories : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.AddColumn<string>(
			name: "ImageUrl",
			table: "Products",
			type: "nvarchar(max)",
			nullable: false,
			defaultValue: "/img/product-default.png");

		migrationBuilder.AddColumn<string>(
			name: "ImageUrl",
			table: "Categories",
			type: "nvarchar(max)",
			nullable: false,
			defaultValue: "/img/product-default.png");

		migrationBuilder.AddColumn<string>(
			name: "ImageUrl",
			table: "AspNetUsers",
			type: "nvarchar(max)",
			nullable: false,
			defaultValue: "/img/profile-default.png");
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropColumn(
			name: "ImageUrl",
			table: "Products");

		migrationBuilder.DropColumn(
			name: "ImageUrl",
			table: "Categories");

		migrationBuilder.DropColumn(
			name: "ImageUrl",
			table: "AspNetUsers");
	}
}
