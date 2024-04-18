using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class AddPriceAndQuantityToOrders : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.AddColumn<decimal>(
			name: "Price",
			table: "Orders",
			type: "money",
			nullable: false,
			defaultValue: 0m);

		migrationBuilder.AddColumn<Guid>(
			name: "UserId",
			table: "Orders",
			type: "uniqueidentifier",
			nullable: false,
			defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

		migrationBuilder.AddColumn<int>(
			name: "Quantity",
			table: "OrderProduct",
			type: "int",
			nullable: false,
			defaultValue: 0);

		migrationBuilder.CreateIndex(
			name: "IX_Orders_UserId",
			table: "Orders",
			column: "UserId");

		migrationBuilder.AddForeignKey(
			name: "FK_Orders_AspNetUsers_UserId",
			table: "Orders",
			column: "UserId",
			principalTable: "AspNetUsers",
			principalColumn: "Id",
			onDelete: ReferentialAction.Cascade);
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropForeignKey(
			name: "FK_Orders_AspNetUsers_UserId",
			table: "Orders");

		migrationBuilder.DropIndex(
			name: "IX_Orders_UserId",
			table: "Orders");

		migrationBuilder.DropColumn(
			name: "Price",
			table: "Orders");

		migrationBuilder.DropColumn(
			name: "UserId",
			table: "Orders");

		migrationBuilder.DropColumn(
			name: "Quantity",
			table: "OrderProduct");
	}
}
