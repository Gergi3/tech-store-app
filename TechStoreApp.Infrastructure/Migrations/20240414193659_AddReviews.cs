using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class AddReviews : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.CreateTable(
			name: "Reviews",
			columns: table => new
			{
				Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				Stars = table.Column<int>(type: "int", nullable: false),
				Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
				UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Reviews", x => x.Id);
				table.ForeignKey(
					name: "FK_Reviews_AspNetUsers_UserId",
					column: x => x.UserId,
					principalTable: "AspNetUsers",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "FK_Reviews_Products_ProductsId",
					column: x => x.ProductsId,
					principalTable: "Products",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateIndex(
			name: "IX_Reviews_ProductsId",
			table: "Reviews",
			column: "ProductsId");

		migrationBuilder.CreateIndex(
			name: "IX_Reviews_UserId",
			table: "Reviews",
			column: "UserId");
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropTable(
			name: "Reviews");
	}
}
