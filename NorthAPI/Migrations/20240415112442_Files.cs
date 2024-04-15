using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NorthAPI.Migrations
{
    /// <inheritdoc />
    public partial class Files : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21f0f5c2-849f-4eaf-b27b-c9cca0e328f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8129673-554b-4b2f-ad3d-58c6433cef29");

            migrationBuilder.AddColumn<string>(
                name: "FieldName",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2844437c-64d3-4b2b-85d8-7e7c5aac1ca1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a15f16f-ec5d-4de8-9b54-270abfe9efb0");

            migrationBuilder.DropColumn(
                name: "FieldName",
                table: "Files");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 4, 15, 11, 19, 11, 148, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 4, 15, 11, 19, 11, 148, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "UserId" },
                values: new object[,]
                {
                    { "21f0f5c2-849f-4eaf-b27b-c9cca0e328f4", null, "Admin", "ADMIN", null },
                    { "a8129673-554b-4b2f-ad3d-58c6433cef29", null, "User", "USER", null }
                });

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 4, 15, 11, 19, 11, 152, DateTimeKind.Utc).AddTicks(6684));
        }
    }
}
