using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class AddQuantityToWishlist : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.AddColumn<int>(
			name: "Quantity",
			table: "Wishlist",
			type: "int",
			nullable: false,
			defaultValue: 1);
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropColumn(
			name: "Quantity",
			table: "Wishlist");
	}
}
