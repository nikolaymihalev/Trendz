using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trendz.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b413215-b02f-4731-8b8b-f142c1c2eb58", "AQAAAAIAAYagAAAAEJXeRX1LR3o3LgN+pwPewYrzRVlKSI47wf0vCP14Gf4RhR5bbWufLSEgPuGYyr0oYw==", "b3281046-0240-4647-92a1-c459b61ce22e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd68a836-f988-4dea-af8d-ad33664480af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60788462-b6ed-4634-8ece-8622457c5018", "AQAAAAIAAYagAAAAEFfsPta0dvhhjNZVYBVnmYZCo5dZNTIQp2YDvwWXKyQ4GeBXzzFPOLuv0uuJT4s5KA==", "eeb078ff-ae56-40de-93d1-377297baf5ce" });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "DiscountPercentage", "EndDate", "ProductId", "StartDate" },
                values: new object[] { 1, 20m, new DateTime(2032, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e43c37f6-407f-4b4e-a5df-842ae35e7f86", "AQAAAAIAAYagAAAAEAcxHcdrs7K4cbFvF9iLer29p4o+PsleltTTsxmER4vWHvLbFuCOVl8gZkkE+QTiZw==", "8fc43354-8eeb-4f0d-8383-fcf43ca57b0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd68a836-f988-4dea-af8d-ad33664480af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63ba2e93-4769-4e63-aa39-1bd2393bf75c", "AQAAAAIAAYagAAAAEEoTNVnu5XeIAxwnJ+TmUhBQ2sfRap11VzPdIxnOKK+d0CSnWRhM6dsdndOsMAOuIg==", "8506ecd4-0bcc-44eb-b2c8-957256202893" });
        }
    }
}
