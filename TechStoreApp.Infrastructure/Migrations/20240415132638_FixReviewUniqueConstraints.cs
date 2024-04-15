using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class FixReviewUniqueConstraints : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropIndex(
			name: "IX_Reviews_ProductsId",
			table: "Reviews");

		migrationBuilder.DropIndex(
			name: "IX_Reviews_UserId",
			table: "Reviews");

		migrationBuilder.CreateIndex(
			name: "IX_Reviews_ProductsId",
			table: "Reviews",
			column: "ProductsId");

		migrationBuilder.CreateIndex(
			name: "IX_Reviews_UserId_ProductsId",
			table: "Reviews",
			columns: new[] { "UserId", "ProductsId" },
			unique: true);
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropIndex(
			name: "IX_Reviews_ProductsId",
			table: "Reviews");

		migrationBuilder.DropIndex(
			name: "IX_Reviews_UserId_ProductsId",
			table: "Reviews");

		migrationBuilder.CreateIndex(
			name: "IX_Reviews_ProductsId",
			table: "Reviews",
			column: "ProductsId",
			unique: true);

		migrationBuilder.CreateIndex(
			name: "IX_Reviews_UserId",
			table: "Reviews",
			column: "UserId",
			unique: true);
	}
}
