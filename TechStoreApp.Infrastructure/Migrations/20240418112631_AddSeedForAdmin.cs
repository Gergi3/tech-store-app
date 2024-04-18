using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class AddSeedForAdmin : Migration
{
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.InsertData(
			table: "AspNetRoles",
			columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
			values: new object[] { new Guid("2358dc72-4280-40da-8986-4cf0cb4988ea"), null, "Admin", null });

		migrationBuilder.InsertData(
			table: "AspNetUsers",
			columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
			values: new object[] { new Guid("05cb6d59-1d3d-4759-bd33-2378d9d9e689"), 0, "e34204cc-ab7a-42a5-aee1-9db33c0f7a85", "admin@mail.com", true, false, null, "admin@mail.com", "Administrator", "AQAAAAIAAYagAAAAEJlovegn7pEMr0v+aFhHbVRpL5gEMji1xLPiImLVu8MYEz7bfp1qmnOYr5MSmeG7Kw==", "0894357237", true, "e649e1cf-6483-4aa0-8077-48b28d726885", false, "Administrator" });

		migrationBuilder.InsertData(
			table: "AspNetUserRoles",
			columns: new[] { "RoleId", "UserId" },
			values: new object[] { new Guid("2358dc72-4280-40da-8986-4cf0cb4988ea"), new Guid("05cb6d59-1d3d-4759-bd33-2378d9d9e689") });
	}

	/// <inheritdoc />
	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DeleteData(
			table: "AspNetUserRoles",
			keyColumns: new[] { "RoleId", "UserId" },
			keyValues: new object[] { new Guid("2358dc72-4280-40da-8986-4cf0cb4988ea"), new Guid("05cb6d59-1d3d-4759-bd33-2378d9d9e689") });

		migrationBuilder.DeleteData(
			table: "AspNetRoles",
			keyColumn: "Id",
			keyValue: new Guid("2358dc72-4280-40da-8986-4cf0cb4988ea"));

		migrationBuilder.DeleteData(
			table: "AspNetUsers",
			keyColumn: "Id",
			keyValue: new Guid("05cb6d59-1d3d-4759-bd33-2378d9d9e689"));
	}
}
