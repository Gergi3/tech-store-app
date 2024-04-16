using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class AddOrders : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.CreateTable(
			name: "Orders",
			columns: table => new
			{
				Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
				LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
				CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
				Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
				City = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
				OrderNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Orders", x => x.Id);
			});

		migrationBuilder.CreateTable(
			name: "OrderProduct",
			columns: table => new
			{
				ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				OrdersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_OrderProduct", x => new { x.ProductsId, x.OrdersId });
				table.ForeignKey(
					name: "FK_OrderProduct_Orders_OrdersId",
					column: x => x.OrdersId,
					principalTable: "Orders",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "FK_OrderProduct_Products_ProductsId",
					column: x => x.ProductsId,
					principalTable: "Products",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateIndex(
			name: "IX_OrderProduct_OrdersId",
			table: "OrderProduct",
			column: "OrdersId");
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropTable(
			name: "OrderProduct");

		migrationBuilder.DropTable(
			name: "Orders");
	}
}
