using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NorthAPI.Migrations
{
    /// <inheritdoc />
    public partial class AppInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2844437c-64d3-4b2b-85d8-7e7c5aac1ca1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a15f16f-ec5d-4de8-9b54-270abfe9efb0");

            migrationBuilder.CreateTable(
                name: "AppInfo",
                columns: table => new
                {
                    InfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfoContentId = table.Column<int>(type: "int", nullable: false),
                    InfoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInfo", x => x.InfoId);
                });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 4, 15, 12, 2, 12, 621, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 4, 15, 12, 2, 12, 621, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "UserId" },
                values: new object[,]
                {
                    { "4ec275ab-ff1e-4fbc-9bd1-1e0612412582", null, "Admin", "ADMIN", null },
                    { "98699155-caf0-4deb-9007-151772898c1a", null, "User", "USER", null }
                });

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 4, 15, 12, 2, 12, 626, DateTimeKind.Utc).AddTicks(943));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppInfo");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ec275ab-ff1e-4fbc-9bd1-1e0612412582");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98699155-caf0-4deb-9007-151772898c1a");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 4, 15, 11, 24, 42, 281, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 4, 15, 11, 24, 42, 281, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "UserId" },
                values: new object[,]
                {
                    { "2844437c-64d3-4b2b-85d8-7e7c5aac1ca1", null, "User", "USER", null },
                    { "8a15f16f-ec5d-4de8-9b54-270abfe9efb0", null, "Admin", "ADMIN", null }
                });

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 4, 15, 11, 24, 42, 285, DateTimeKind.Utc).AddTicks(6694));
        }
    }
}
