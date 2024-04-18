using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechStoreApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8524d2e-dc6b-43a8-8226-d69be9697df0", "AQAAAAIAAYagAAAAED8ela1zfKGmA0kY21KUamB8xm88Qd4WJDP777UDptUarTXg7MTeeNyhVEAW3YQNfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ab01f0e-b914-4768-a95d-bec9d3e9b831", "AQAAAAIAAYagAAAAEDqKqlcp+9A5bGOdRZVLx2FwOPvmowxXWkFotrKflsIzE2btfsSzs2YuhGBgsTngAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ae5dcd9-d67f-4c6e-9d5f-7983d07fe2e6", "AQAAAAIAAYagAAAAEGS19ZEuIAmg55r2UV8vYDehGq955rSjTTtJ49qXYJ9m85seqrkeNZ35MtwOA55hGw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53b2b45f-c827-499e-9905-4feae15fe14e", "AQAAAAIAAYagAAAAEPT5w5laiE6cLsru7RYmSpFg0Dy8+SEDfcvNyoNSff7D36EG/hJ1Rj+7LaK5SHfOEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ba8189e-6ca6-47b7-8f9e-63cb4c23bea8", "AQAAAAIAAYagAAAAEHGHFMcM8/NM+4zfeoLQGCXOooS2wmXR13cEl1RuTg0EVgt4VcBjwO2q99X662C3eQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05cb6d59-1d3d-4759-bd33-2378d9d9e689"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "409d00c1-ab8b-4180-917f-37445324bae5", "AQAAAAIAAYagAAAAELQkKDzFYqYgIO/QA7U9k4lIZ31Hhh3jZIHNN3ibkJgauZQYIH6GUmcZmhWU6J0LBA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000006"), 0, "0a00294c-f00f-49ba-a6c3-6581bb7bc743", "reviewer6@mail.com", true, false, null, "REVIEWER6@MAIL.COM", "LiamAnderson", "AQAAAAIAAYagAAAAEEAJqUcbDF+xD99DoX1VAKk3SERANQsJICWzow9VfIrPfN9zz8/TpoNMeVHkLvkDrw==", null, true, "00000000-0000-0000-0000-000000000006", false, "LiamAnderson" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), 0, "906063a4-d115-41bc-b0a9-33f90a362181", "reviewer7@mail.com", true, false, null, "REVIEWER7@MAIL.COM", "AvaWilson", "AQAAAAIAAYagAAAAELM4BJO9HOCcGdbtLYWd8Xl6YNWxC708UwhqWJAC+nEZoCCr16K7t3DHllGpfCLotQ==", null, true, "00000000-0000-0000-0000-000000000007", false, "AvaWilson" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), 0, "e0e82733-7d5f-4f51-b16f-c44d4cfcd54d", "reviewer8@mail.com", true, false, null, "REVIEWER8@MAIL.COM", "NoahTaylor", "AQAAAAIAAYagAAAAEOEQSmvmMr6vzsFcVfdx4nr/FUeaWI+DwgZw1DDU2ORMuuNNvdFrb8esvvAnN1lCww==", null, true, "00000000-0000-0000-0000-000000000008", false, "NoahTaylor" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), 0, "cb6bda8e-2b04-4c72-bd70-6d5a3e4996c3", "reviewer9@mail.com", true, false, null, "REVIEWER9@MAIL.COM", "IsabellaThomas", "AQAAAAIAAYagAAAAEDa+aqkDvpRPQDvTmov555wyTzwPDVKTD8/4cJEYgNXYu2XSXbpC/Oq1bDrk2gpbHw==", null, true, "00000000-0000-0000-0000-000000000009", false, "IsabellaThomas" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), 0, "eb699122-347e-4af5-9a20-21ace79c8d6b", "reviewer10@mail.com", true, false, null, "REVIEWER10@MAIL.COM", "MasonClark", "AQAAAAIAAYagAAAAEPW8/E+aCB0//IYAqWeWc3NKKOuxcyl+c8Ud9yCPMhXifZkBuoT+6Co76Ho4f/wBaQ==", null, true, "00000000-0000-0000-0000-000000000010", false, "MasonClark" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), 0, "3ab17e13-de4b-47c4-84a5-9e51ba9d294d", "reviewer11@mail.com", true, false, null, "REVIEWER11@MAIL.COM", "MiaRodriguez", "AQAAAAIAAYagAAAAEBdCb8Emy9Pvb+BpJXYivXphY1AFnkpfNb3Cq5/071hUUckrJ2Iez+RLLw9YyL74UQ==", null, true, "00000000-0000-0000-0000-000000000011", false, "MiaRodriguez" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), 0, "8ac435b5-8955-4111-8c39-4e2d38a40c89", "reviewer12@mail.com", true, false, null, "REVIEWER12@MAIL.COM", "WilliamLewis", "AQAAAAIAAYagAAAAEJCh5F2iCkM1aireGyxzUwX6J6EpawUyCafwFXviAgAYPmkmRIo57EBCYuynzOS80g==", null, true, "00000000-0000-0000-0000-000000000012", false, "WilliamLewis" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), 0, "faa3aa50-e4f5-4c0f-a6d0-c264e99bcf44", "reviewer13@mail.com", true, false, null, "REVIEWER13@MAIL.COM", "CharlotteLee", "AQAAAAIAAYagAAAAECM8dX+Vmd/VtJlrtSFUHB8O2yIfa4rk8Pt39yoKIl9xGDcPj70rk4knxRzABaWnTg==", null, true, "00000000-0000-0000-0000-000000000013", false, "CharlotteLee" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), 0, "bc4672a2-54e9-4991-bd8b-e18c68749a25", "reviewer14@mail.com", true, false, null, "REVIEWER14@MAIL.COM", "JamesWalker", "AQAAAAIAAYagAAAAECqbCUNCM/WHqk4iOsSQ2sI/XmN29u1alktyuchrPuK6A79HCkNCiKY8grkn11vQnQ==", null, true, "00000000-0000-0000-0000-000000000014", false, "JamesWalker" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), 0, "d425c6bf-10ef-41eb-9bff-8572133ba53c", "reviewer15@mail.com", true, false, null, "REVIEWER15@MAIL.COM", "AmeliaHall", "AQAAAAIAAYagAAAAEAl63GjdsyNdTD1501Vpd7CrHfB9v/XKeHNObxebI8ZIUEBtJno4nr+t2vhgVfZXjw==", null, true, "00000000-0000-0000-0000-000000000015", false, "AmeliaHall" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ProductsId", "Stars", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000001-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000002-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000003-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000004-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000005-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000012-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000013-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000014-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000015-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000016-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000023-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000024-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000025-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000026-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000027-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000035-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000036-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000037-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000038-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000039-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000047-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000048-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000049-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000050-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000051-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000059-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000060-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000061-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000062-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000063-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000071-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000072-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000073-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000074-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000075-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000084-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000085-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000086-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000087-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000088-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000097-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000098-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000099-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000100-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000101-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000110-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000010"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000111-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000011"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000112-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000012"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000113-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000012"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000114-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000013"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000115-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000013"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000116-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000014"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000117-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000014"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000118-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000015"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000119-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000015"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000120-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000015"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000121-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000016"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000122-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000016"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000123-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000016"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000124-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000017"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000125-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000017"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000126-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000017"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000127-0000-0000-0000-000000000018"), new Guid("00000000-0000-0000-0000-000000000018"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000128-0000-0000-0000-000000000018"), new Guid("00000000-0000-0000-0000-000000000018"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000129-0000-0000-0000-000000000018"), new Guid("00000000-0000-0000-0000-000000000018"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000130-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000019"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000131-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000019"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000132-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000019"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000133-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000019"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000134-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000020"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000135-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000020"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000136-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000020"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000137-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000020"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000138-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000020"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000140-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000021"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000141-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000021"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000142-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000021"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000143-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000021"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000144-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000021"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000146-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000022"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000147-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000022"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000148-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000022"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000149-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000022"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000150-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000022"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000152-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000023"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000153-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000023"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000154-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000023"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000155-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000023"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000156-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000023"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000158-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000024"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000159-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000024"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000160-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000024"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000161-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000024"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000162-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000024"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000165-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000025"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000166-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000025"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000167-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000025"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000168-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000025"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000169-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000025"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000172-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000026"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000173-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000026"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000174-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000026"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000175-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000026"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000176-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000026"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000179-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000027"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000180-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000027"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000181-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000027"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000182-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000027"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000183-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000027"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000187-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000028"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000188-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000028"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000189-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000028"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000190-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000028"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000191-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000028"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000195-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000029"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000196-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000029"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000197-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000029"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000198-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000029"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000199-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000029"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000203-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000204-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000205-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000206-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000207-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000215-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000216-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000217-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000218-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000219-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000227-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000228-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000229-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000230-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000231-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000238-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000239-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000240-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000241-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000242-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000249-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000250-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000251-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000252-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000253-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000260-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000261-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000262-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000263-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000264-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000270-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000271-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000272-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000273-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000274-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000280-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000281-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000282-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000283-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000284-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000290-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000291-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000292-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000293-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000294-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000300-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000039"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000301-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000039"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000302-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000039"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000303-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000039"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000304-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000039"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000309-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000040"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000310-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000040"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000311-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000040"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000312-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000040"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000313-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000040"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000316-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000041"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000317-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000041"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000318-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000041"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000319-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000041"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000320-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000041"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000323-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-000000000042"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000324-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-000000000042"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000325-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-000000000042"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000326-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-000000000042"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000327-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-000000000042"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000330-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-000000000043"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000331-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-000000000043"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000332-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-000000000043"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000333-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-000000000043"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000334-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-000000000043"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000336-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-000000000044"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000337-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-000000000044"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000338-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-000000000044"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000339-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-000000000044"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000340-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-000000000044"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000342-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000045"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000343-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000045"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000344-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000045"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000345-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000045"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000346-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000045"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000348-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000046"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000349-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000046"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000350-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000046"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000351-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000046"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000352-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000046"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000354-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-000000000047"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000355-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-000000000047"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000356-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-000000000047"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000357-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-000000000047"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000358-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-000000000047"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000359-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000048"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000360-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000048"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000361-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000048"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000362-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000048"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000363-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000048"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000364-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000049"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000365-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000049"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000366-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000049"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000367-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000049"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000368-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000049"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000369-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000050"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000370-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000050"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000371-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000050"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000372-0000-0000-0000-000000000051"), new Guid("00000000-0000-0000-0000-000000000051"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000373-0000-0000-0000-000000000051"), new Guid("00000000-0000-0000-0000-000000000051"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000374-0000-0000-0000-000000000051"), new Guid("00000000-0000-0000-0000-000000000051"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000375-0000-0000-0000-000000000052"), new Guid("00000000-0000-0000-0000-000000000052"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000376-0000-0000-0000-000000000052"), new Guid("00000000-0000-0000-0000-000000000052"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000377-0000-0000-0000-000000000053"), new Guid("00000000-0000-0000-0000-000000000053"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000378-0000-0000-0000-000000000053"), new Guid("00000000-0000-0000-0000-000000000053"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000379-0000-0000-0000-000000000054"), new Guid("00000000-0000-0000-0000-000000000054"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000380-0000-0000-0000-000000000054"), new Guid("00000000-0000-0000-0000-000000000054"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000381-0000-0000-0000-000000000055"), new Guid("00000000-0000-0000-0000-000000000055"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000382-0000-0000-0000-000000000056"), new Guid("00000000-0000-0000-0000-000000000056"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000383-0000-0000-0000-000000000056"), new Guid("00000000-0000-0000-0000-000000000056"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000384-0000-0000-0000-000000000056"), new Guid("00000000-0000-0000-0000-000000000056"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000385-0000-0000-0000-000000000056"), new Guid("00000000-0000-0000-0000-000000000056"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000386-0000-0000-0000-000000000056"), new Guid("00000000-0000-0000-0000-000000000056"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000388-0000-0000-0000-000000000057"), new Guid("00000000-0000-0000-0000-000000000057"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000389-0000-0000-0000-000000000057"), new Guid("00000000-0000-0000-0000-000000000057"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000390-0000-0000-0000-000000000057"), new Guid("00000000-0000-0000-0000-000000000057"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000391-0000-0000-0000-000000000057"), new Guid("00000000-0000-0000-0000-000000000057"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000392-0000-0000-0000-000000000057"), new Guid("00000000-0000-0000-0000-000000000057"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000394-0000-0000-0000-000000000058"), new Guid("00000000-0000-0000-0000-000000000058"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000395-0000-0000-0000-000000000058"), new Guid("00000000-0000-0000-0000-000000000058"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000396-0000-0000-0000-000000000058"), new Guid("00000000-0000-0000-0000-000000000058"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000397-0000-0000-0000-000000000058"), new Guid("00000000-0000-0000-0000-000000000058"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000398-0000-0000-0000-000000000058"), new Guid("00000000-0000-0000-0000-000000000058"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000401-0000-0000-0000-000000000059"), new Guid("00000000-0000-0000-0000-000000000059"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000402-0000-0000-0000-000000000059"), new Guid("00000000-0000-0000-0000-000000000059"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000403-0000-0000-0000-000000000059"), new Guid("00000000-0000-0000-0000-000000000059"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000404-0000-0000-0000-000000000059"), new Guid("00000000-0000-0000-0000-000000000059"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000405-0000-0000-0000-000000000059"), new Guid("00000000-0000-0000-0000-000000000059"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000408-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000060"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000409-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000060"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000410-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000060"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000411-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000060"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000412-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000060"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000417-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000061"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000418-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000061"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000419-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000061"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000420-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000061"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000421-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000061"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000426-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000427-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000428-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000429-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000430-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000436-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000437-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000438-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000439-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000440-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000446-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000447-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000448-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000449-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000450-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000456-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000457-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000458-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000459-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000460-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000466-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000467-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000468-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000469-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000470-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000477-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000478-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000479-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000480-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000481-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000488-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000489-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000490-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000491-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000492-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000499-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000500-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000501-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000502-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000503-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000511-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000512-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000513-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000514-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000515-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000524-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000525-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000526-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000527-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000528-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000538-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000539-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000540-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000541-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000542-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000552-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000553-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000554-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000555-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000556-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000566-0000-0000-0000-000000000074"), new Guid("00000000-0000-0000-0000-000000000074"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000567-0000-0000-0000-000000000075"), new Guid("00000000-0000-0000-0000-000000000075"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000568-0000-0000-0000-000000000076"), new Guid("00000000-0000-0000-0000-000000000076"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000569-0000-0000-0000-000000000077"), new Guid("00000000-0000-0000-0000-000000000077"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000570-0000-0000-0000-000000000078"), new Guid("00000000-0000-0000-0000-000000000078"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000571-0000-0000-0000-000000000078"), new Guid("00000000-0000-0000-0000-000000000078"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000572-0000-0000-0000-000000000079"), new Guid("00000000-0000-0000-0000-000000000079"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000573-0000-0000-0000-000000000079"), new Guid("00000000-0000-0000-0000-000000000079"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000574-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000575-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000576-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000577-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000578-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000585-0000-0000-0000-000000000081"), new Guid("00000000-0000-0000-0000-000000000081"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000586-0000-0000-0000-000000000081"), new Guid("00000000-0000-0000-0000-000000000081"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000587-0000-0000-0000-000000000081"), new Guid("00000000-0000-0000-0000-000000000081"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000588-0000-0000-0000-000000000081"), new Guid("00000000-0000-0000-0000-000000000081"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000589-0000-0000-0000-000000000082"), new Guid("00000000-0000-0000-0000-000000000082"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000590-0000-0000-0000-000000000082"), new Guid("00000000-0000-0000-0000-000000000082"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000591-0000-0000-0000-000000000082"), new Guid("00000000-0000-0000-0000-000000000082"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000592-0000-0000-0000-000000000083"), new Guid("00000000-0000-0000-0000-000000000083"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000593-0000-0000-0000-000000000083"), new Guid("00000000-0000-0000-0000-000000000083"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000594-0000-0000-0000-000000000083"), new Guid("00000000-0000-0000-0000-000000000083"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000595-0000-0000-0000-000000000084"), new Guid("00000000-0000-0000-0000-000000000084"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000596-0000-0000-0000-000000000084"), new Guid("00000000-0000-0000-0000-000000000084"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000597-0000-0000-0000-000000000084"), new Guid("00000000-0000-0000-0000-000000000084"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000598-0000-0000-0000-000000000085"), new Guid("00000000-0000-0000-0000-000000000085"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000599-0000-0000-0000-000000000085"), new Guid("00000000-0000-0000-0000-000000000085"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000600-0000-0000-0000-000000000085"), new Guid("00000000-0000-0000-0000-000000000085"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000601-0000-0000-0000-000000000086"), new Guid("00000000-0000-0000-0000-000000000086"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000602-0000-0000-0000-000000000086"), new Guid("00000000-0000-0000-0000-000000000086"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000603-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000087"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000604-0000-0000-0000-000000000087"), new Guid("00000000-0000-0000-0000-000000000087"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000605-0000-0000-0000-000000000088"), new Guid("00000000-0000-0000-0000-000000000088"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000606-0000-0000-0000-000000000088"), new Guid("00000000-0000-0000-0000-000000000088"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000607-0000-0000-0000-000000000089"), new Guid("00000000-0000-0000-0000-000000000089"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000608-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000609-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000610-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000611-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000612-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000621-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000622-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000623-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000624-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000625-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000634-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000635-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000636-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000637-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000638-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000647-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000648-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000649-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000650-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000651-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000660-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000661-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000662-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000663-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000664-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000672-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000673-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000674-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000675-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000676-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000684-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000685-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000686-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000687-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000688-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000696-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000697-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000698-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000699-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000700-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000708-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000709-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000710-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000711-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000712-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000719-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000720-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000721-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000722-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000723-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000006-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000007-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000008-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000009-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000010-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000011-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000017-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000018-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000019-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000020-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000021-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000022-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000028-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000029-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000030-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000031-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000032-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000033-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000034-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000040-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000041-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000042-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000043-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000044-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000045-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000046-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000052-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000053-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000054-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000055-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000056-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000057-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000058-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000064-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000065-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000066-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000067-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000068-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000069-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000070-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000076-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000077-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000078-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000079-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000080-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000081-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000082-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000083-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000089-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000090-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000091-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000092-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000093-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000094-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000095-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000096-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000102-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000103-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000104-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000105-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000106-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000107-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000108-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000109-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000139-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000020"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000145-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000021"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000151-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000022"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000157-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000023"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000163-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000024"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000164-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000024"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000170-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000025"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000171-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000025"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000177-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000026"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000178-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000026"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000184-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000027"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000185-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000027"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000186-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000027"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000192-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000028"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000193-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000028"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000194-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000028"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000200-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000029"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000201-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000029"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000202-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000029"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000208-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000209-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000210-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000211-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000212-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000213-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000214-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000030"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000220-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000221-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000222-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000223-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000224-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000225-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000226-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000031"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000232-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000233-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000234-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000235-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000236-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000237-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000032"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000243-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000244-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000245-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000246-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000247-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000248-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000033"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000254-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000255-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000256-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000257-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000258-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000259-0000-0000-0000-000000000034"), new Guid("00000000-0000-0000-0000-000000000034"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000265-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000266-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000267-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000268-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000269-0000-0000-0000-000000000035"), new Guid("00000000-0000-0000-0000-000000000035"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000275-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000276-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000277-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000278-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000279-0000-0000-0000-000000000036"), new Guid("00000000-0000-0000-0000-000000000036"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000285-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000286-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000287-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000288-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000289-0000-0000-0000-000000000037"), new Guid("00000000-0000-0000-0000-000000000037"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000295-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000296-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000297-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000298-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000299-0000-0000-0000-000000000038"), new Guid("00000000-0000-0000-0000-000000000038"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000305-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000039"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000306-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000039"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000307-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000039"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000308-0000-0000-0000-000000000039"), new Guid("00000000-0000-0000-0000-000000000039"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000314-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000040"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000315-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000040"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000321-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000041"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000322-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000041"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000328-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-000000000042"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000329-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-000000000042"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000335-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-000000000043"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000341-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-000000000044"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000347-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000045"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000353-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000046"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000387-0000-0000-0000-000000000056"), new Guid("00000000-0000-0000-0000-000000000056"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000393-0000-0000-0000-000000000057"), new Guid("00000000-0000-0000-0000-000000000057"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000399-0000-0000-0000-000000000058"), new Guid("00000000-0000-0000-0000-000000000058"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000400-0000-0000-0000-000000000058"), new Guid("00000000-0000-0000-0000-000000000058"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000406-0000-0000-0000-000000000059"), new Guid("00000000-0000-0000-0000-000000000059"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000407-0000-0000-0000-000000000059"), new Guid("00000000-0000-0000-0000-000000000059"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000413-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000060"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000414-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000060"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000415-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000060"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000416-0000-0000-0000-000000000060"), new Guid("00000000-0000-0000-0000-000000000060"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000422-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000061"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000423-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000061"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000424-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000061"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000425-0000-0000-0000-000000000061"), new Guid("00000000-0000-0000-0000-000000000061"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000431-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000432-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000433-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000434-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000435-0000-0000-0000-000000000062"), new Guid("00000000-0000-0000-0000-000000000062"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000441-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000442-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000443-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000444-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000445-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-000000000063"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000451-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000452-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000453-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000454-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000455-0000-0000-0000-000000000064"), new Guid("00000000-0000-0000-0000-000000000064"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000461-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000462-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000463-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000464-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000465-0000-0000-0000-000000000065"), new Guid("00000000-0000-0000-0000-000000000065"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000471-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000472-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000473-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000474-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000475-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000476-0000-0000-0000-000000000066"), new Guid("00000000-0000-0000-0000-000000000066"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000482-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000483-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000484-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000485-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000486-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000487-0000-0000-0000-000000000067"), new Guid("00000000-0000-0000-0000-000000000067"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000493-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000494-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000495-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000496-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000497-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000498-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000068"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000504-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000505-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000506-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000507-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000508-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000509-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000510-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000069"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000516-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000517-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000518-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000519-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000520-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000521-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000522-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000523-0000-0000-0000-000000000070"), new Guid("00000000-0000-0000-0000-000000000070"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000529-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000530-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000531-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000532-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000533-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000534-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000535-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000536-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000537-0000-0000-0000-000000000071"), new Guid("00000000-0000-0000-0000-000000000071"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000543-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000544-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000545-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000546-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000547-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000548-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000549-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000550-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000551-0000-0000-0000-000000000072"), new Guid("00000000-0000-0000-0000-000000000072"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000557-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000558-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000559-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000560-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000561-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000562-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000563-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000564-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 4, "Pleased overall, performs well, minor issues.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000565-0000-0000-0000-000000000073"), new Guid("00000000-0000-0000-0000-000000000073"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000579-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000580-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000581-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000582-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000583-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000584-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000080"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000613-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000614-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000615-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000616-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000617-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000618-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000619-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000620-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-000000000090"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000626-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000627-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000628-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000629-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000630-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000631-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000632-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000633-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-000000000091"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000639-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000640-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000641-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000642-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000643-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000644-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000645-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 3, "Functional but flawed, average quality, worth considering on a budget.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000646-0000-0000-0000-000000000092"), new Guid("00000000-0000-0000-0000-000000000092"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000652-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000653-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000654-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000655-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000656-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 4, "Good value for money, mostly satisfied, could be improved.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000657-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000658-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000659-0000-0000-0000-000000000093"), new Guid("00000000-0000-0000-0000-000000000093"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000665-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000666-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000667-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000668-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000669-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000670-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000671-0000-0000-0000-000000000094"), new Guid("00000000-0000-0000-0000-000000000094"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000677-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000678-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000679-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 2, "Wanted to like it, lacks features, expected more for price.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000680-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000681-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000682-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000683-0000-0000-0000-000000000095"), new Guid("00000000-0000-0000-0000-000000000095"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000689-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000690-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000691-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000692-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000693-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000694-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000695-0000-0000-0000-000000000096"), new Guid("00000000-0000-0000-0000-000000000096"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000701-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000702-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 1, "Terrible quality, fell apart within days, regret buying.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000703-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000704-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000705-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000706-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 1, "Complete disappointment, didn't work, broke quickly.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000707-0000-0000-0000-000000000097"), new Guid("00000000-0000-0000-0000-000000000097"), 2, "Fell short of expectations, functional but feels cheap.", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000713-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 5, "Love it! Exceeded expectations, game-changer.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000714-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000715-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000716-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000717-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 3, "Okay product, not special, better options available.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000718-0000-0000-0000-000000000098"), new Guid("00000000-0000-0000-0000-000000000098"), 5, "Absolutely recommend! Well-designed, user-friendly, worth every penny.", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000724-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 1, "Waste of money, caused damage, frustrated with purchase.", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000725-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 5, "Outstanding product, exceeded expectations, couldn't be happier.", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000726-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 4, "Happy with purchase, solid product, reliable performance.", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000727-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 2, "Not terrible, but not great either, wouldn't buy again.", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000728-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000729-0000-0000-0000-000000000099"), new Guid("00000000-0000-0000-0000-000000000099"), 3, "Average performance, nothing outstanding, meets basic needs.", new Guid("00000000-0000-0000-0000-000000000011") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000005-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000007-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000008-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000009-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000010-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000011-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000012-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000013-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000014-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000015-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000016-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000017-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000018-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000019-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000020-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000021-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000022-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000023-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000024-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000025-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000026-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000027-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000028-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000029-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000030-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000031-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000032-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000033-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000034-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000035-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000036-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000037-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000038-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000039-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000040-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000041-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000042-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000043-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000044-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000045-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000046-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000047-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000048-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000049-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000050-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000051-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000052-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000053-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000054-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000055-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000056-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000057-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000058-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000059-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000060-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000061-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000062-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000063-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000065-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000066-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000067-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000068-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000069-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000070-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000071-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000072-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000073-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000074-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000075-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000076-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000077-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000078-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000079-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000080-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000081-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000082-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000083-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000084-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000085-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000086-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000087-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000088-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000089-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000090-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000091-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000092-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000093-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000094-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000095-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000096-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000097-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000098-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000099-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000100-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000101-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000102-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000103-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000104-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000105-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000106-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000107-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000108-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000109-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000110-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000111-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000112-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000113-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000114-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000115-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000116-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000117-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000118-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000119-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000120-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000121-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000122-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000123-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000124-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000125-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000126-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000127-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000128-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000129-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000130-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000131-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000132-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000133-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000134-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000135-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000136-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000137-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000138-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000139-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000140-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000141-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000142-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000143-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000144-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000145-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000146-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000147-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000148-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000149-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000150-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000151-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000152-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000153-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000154-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000155-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000156-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000157-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000158-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000159-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000160-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000161-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000162-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000163-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000164-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000165-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000166-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000167-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000168-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000169-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000170-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000171-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000172-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000173-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000174-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000175-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000176-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000177-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000178-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000179-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000180-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000181-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000182-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000183-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000184-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000185-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000186-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000187-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000188-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000189-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000191-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000192-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000193-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000194-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000195-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000196-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000197-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000198-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000199-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000200-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000201-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000202-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000203-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000204-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000205-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000206-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000207-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000208-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000209-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000210-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000211-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000212-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000213-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000214-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000215-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000216-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000217-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000218-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000219-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000220-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000221-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000222-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000223-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000224-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000225-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000226-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000227-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000228-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000229-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000230-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000231-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000232-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000233-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000234-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000235-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000236-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000237-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000238-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000239-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000240-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000241-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000242-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000243-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000244-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000245-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000246-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000247-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000248-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000249-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000250-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000251-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000252-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000253-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000254-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000255-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000256-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000257-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000259-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000260-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000261-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000263-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000264-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000265-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000266-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000267-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000268-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000269-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000270-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000271-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000272-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000273-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000274-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000275-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000276-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000277-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000278-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000279-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000280-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000281-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000282-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000283-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000284-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000285-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000286-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000287-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000288-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000289-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000290-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000291-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000292-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000293-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000294-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000295-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000296-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000297-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000298-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000299-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000300-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000301-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000302-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000303-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000304-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000305-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000306-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000307-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000308-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000309-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000310-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000311-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000312-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000313-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000314-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000315-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000316-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000317-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000318-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000319-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000321-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000322-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000323-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000324-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000325-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000326-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000327-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000328-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000329-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000330-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000331-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000332-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000333-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000335-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000336-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000337-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000338-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000339-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000340-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000341-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000342-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000343-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000344-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000345-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000346-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000347-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000348-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000349-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000350-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000351-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000352-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000353-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000354-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000355-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000356-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000357-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000358-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000359-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000360-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000361-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000362-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000363-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000364-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000365-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000366-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000367-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000368-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000369-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000370-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000371-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000372-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000373-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000374-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000375-0000-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000376-0000-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000377-0000-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000378-0000-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000379-0000-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000380-0000-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000381-0000-0000-0000-000000000055"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000382-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000383-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000385-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000386-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000387-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000388-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000389-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000390-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000391-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000392-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000393-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000394-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000395-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000396-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000397-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000398-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000399-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000400-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000401-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000402-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000403-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000404-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000405-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000406-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000407-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000408-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000409-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000410-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000411-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000412-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000413-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000414-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000415-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000416-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000417-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000418-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000419-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000420-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000421-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000422-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000423-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000424-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000425-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000426-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000427-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000428-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000429-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000430-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000431-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000432-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000433-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000434-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000435-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000436-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000437-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000438-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000439-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000440-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000441-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000442-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000443-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000444-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000445-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000446-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000447-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000448-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000449-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000450-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000451-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000452-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000453-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000454-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000455-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000456-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000457-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000458-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000459-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000460-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000461-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000462-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000463-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000464-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000465-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000466-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000467-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000468-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000469-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000470-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000471-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000472-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000473-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000474-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000475-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000476-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000477-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000478-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000479-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000480-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000481-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000482-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000483-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000484-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000485-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000486-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000487-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000488-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000489-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000490-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000491-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000492-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000493-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000494-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000495-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000496-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000497-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000498-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000499-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000500-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000501-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000502-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000503-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000504-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000505-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000506-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000507-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000508-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000509-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000510-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000511-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000512-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000513-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000514-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000515-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000516-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000517-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000518-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000519-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000520-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000521-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000522-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000523-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000524-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000525-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000526-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000527-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000528-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000529-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000530-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000531-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000532-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000533-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000534-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000535-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000536-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000537-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000538-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000539-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000540-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000541-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000542-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000543-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000544-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000545-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000546-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000547-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000548-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000549-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000550-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000551-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000552-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000553-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000554-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000555-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000556-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000557-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000558-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000559-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000560-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000561-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000562-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000563-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000564-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000565-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000566-0000-0000-0000-000000000074"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000567-0000-0000-0000-000000000075"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000568-0000-0000-0000-000000000076"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000569-0000-0000-0000-000000000077"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000570-0000-0000-0000-000000000078"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000571-0000-0000-0000-000000000078"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000572-0000-0000-0000-000000000079"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000573-0000-0000-0000-000000000079"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000574-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000575-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000576-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000577-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000578-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000579-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000580-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000581-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000582-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000583-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000584-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000585-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000586-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000587-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000588-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000589-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000590-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000591-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000592-0000-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000593-0000-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000594-0000-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000595-0000-0000-0000-000000000084"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000596-0000-0000-0000-000000000084"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000597-0000-0000-0000-000000000084"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000598-0000-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000599-0000-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000600-0000-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000601-0000-0000-0000-000000000086"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000602-0000-0000-0000-000000000086"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000603-0000-0000-0000-000000000087"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000604-0000-0000-0000-000000000087"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000605-0000-0000-0000-000000000088"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000606-0000-0000-0000-000000000088"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000607-0000-0000-0000-000000000089"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000608-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000609-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000610-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000611-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000612-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000613-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000614-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000615-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000616-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000617-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000618-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000619-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000620-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000621-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000622-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000623-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000624-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000625-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000626-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000627-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000628-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000629-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000630-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000631-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000632-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000633-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000634-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000635-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000636-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000637-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000638-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000639-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000640-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000641-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000642-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000643-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000644-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000645-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000646-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000647-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000648-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000649-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000650-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000651-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000652-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000653-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000654-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000655-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000656-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000657-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000658-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000659-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000660-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000661-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000662-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000663-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000664-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000665-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000666-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000667-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000668-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000669-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000670-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000671-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000672-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000673-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000674-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000675-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000676-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000677-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000678-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000679-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000680-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000681-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000682-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000683-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000684-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000685-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000686-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000687-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000688-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000689-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000690-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000691-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000692-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000693-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000694-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000695-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000696-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000697-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000698-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000699-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000700-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000701-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000702-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000703-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000704-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000705-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000706-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000707-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000708-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000709-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000710-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000711-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000712-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000713-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000714-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000715-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000716-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000717-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000718-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000719-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000720-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000721-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000722-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000723-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000724-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000725-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000726-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000727-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000728-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("00000729-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c62acc7-e701-4139-ad78-982ee91f9473", "AQAAAAIAAYagAAAAEFsBRY5ZZanJWe5CMlJb+m1J8C4Aujas00VMN7q65vcCOsIo6C/GjExcjPxYyKBEMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71f0c75c-4adf-48fd-b94b-9eec954afba4", "AQAAAAIAAYagAAAAELpe/qlszZ6uwo60Kgw6SidUpbLr/Z5M9jeSR+QjwWzada4qfGyeaSa/FuvLzwbMwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d64e427-a78a-4e46-ab40-aefe25abe474", "AQAAAAIAAYagAAAAELqvIkMY3jKfdPpG/fZqw3aGkPXWUB4GvpvLth9MWs2N016sQTXcoCfU0VWd5d3HaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a5f910a-bfba-4e52-8104-1858cb56dbdf", "AQAAAAIAAYagAAAAEFXgjyOHknYultPDAfWylqMSyLauxjZ1JjxhNSLh+kTpn5LuJ3aka6dEGoHKbnzlrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df552ac0-efbf-42b1-8f4c-2ec189cef6ae", "AQAAAAIAAYagAAAAEGVztAuDpBzL3myrFQLDQqBM/Mtor3wFTb+oXm385BcIOZtEdTGcP8dIf/l9oUyKOQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05cb6d59-1d3d-4759-bd33-2378d9d9e689"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f271631-add0-4586-a79a-c2702eab877b", "AQAAAAIAAYagAAAAEGoMhGx+iKGaWDnjpaIQwVNCStp2RMXbzHcIKXBeZrt6goSNT1HcdHy/v57jp9XDCw==" });
        }
    }
}
