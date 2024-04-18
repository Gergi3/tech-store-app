using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechStoreApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSeeding : Migration
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
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 0, "55d1ac7d-6219-43d9-b42f-6bbbc3f8bfa0", "reviewer1@mail.com", true, false, null, "REVIEWER1@MAIL.COM", "EmilyJohnson", "AQAAAAIAAYagAAAAEPA35KkZYY8mRUIkEZRqwal6Nf/uD/CPv4Ut7z/PWvjYBbmG6Fo3GmGCo1bvicQ8dQ==", null, true, "00000000-0000-0000-0000-000000000001", false, "EmilyJohnson" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 0, "0c9c5272-4ac8-47ec-9828-0d4aa5b515ef", "reviewer2@mail.com", true, false, null, "REVIEWER2@MAIL.COM", "JacobSmith", "AQAAAAIAAYagAAAAEDmFdhNh592m576cotUOfgTgwGx9DtEBokKf5ZDsZM0iu93tGWaXnRqgesAzVamWPg==", null, true, "00000000-0000-0000-0000-000000000002", false, "JacobSmith" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 0, "5eddbfdb-724f-4e6f-a95d-2e47d072df4d", "reviewer3@mail.com", true, false, null, "REVIEWER3@MAIL.COM", "SophiaBrown", "AQAAAAIAAYagAAAAEP0X+oJWQQvPi69fOh+vxAM3xUWLRakmQS+rH7r7GV1GSc+yDrNnH5SIzO71f6zGMw==", null, true, "00000000-0000-0000-0000-000000000003", false, "SophiaBrown" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 0, "f29c3b4b-a206-4f57-bd57-042a4a95d188", "reviewer4@mail.com", true, false, null, "REVIEWER4@MAIL.COM", "EthanDavis", "AQAAAAIAAYagAAAAEOOASy9RVwTQCCQU8OiORB8sfTEQnK80SS//QROtn8cvLFlkPqd30HbWqB5jTbM1DA==", null, true, "00000000-0000-0000-0000-000000000004", false, "EthanDavis" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), 0, "ea84a723-c5f7-4cbc-a113-ec6182f8ec6c", "reviewer5@mail.com", true, false, null, "REVIEWER5@MAIL.COM", "OliviaMartinez", "AQAAAAIAAYagAAAAEId7P7jOEnIRT9e4Plc/JgDlJIYXHnMdjjD+/awzOu2Ix/2KNTOiS0FgXhW1/TN8xA==", null, true, "00000000-0000-0000-0000-000000000005", false, "OliviaMartinez" },
                    { new Guid("05cb6d59-1d3d-4759-bd33-2378d9d9e689"), 0, "ff768869-d250-456d-9aa0-5ab8bf4136d6", "admin@mail.com", true, false, null, "admin@mail.com", "Administrator", "AQAAAAIAAYagAAAAEInObkt/xMozP1p0TQqJU2teHfwM8o23PO2/XyuIzod0qmmXc/cC9wPhfNiYdOtdCw==", "0894357237", true, "05cb6d59-1d3d-4759-bd33-2378d9d9e689", false, "Administrator" }
                });

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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

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
}
