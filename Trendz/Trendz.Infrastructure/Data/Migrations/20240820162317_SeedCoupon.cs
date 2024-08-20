﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trendz.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCoupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50a8e823-dff9-4924-aaf5-955816d76d1d", "AQAAAAIAAYagAAAAEBhfhNgGE89FryH2vqG/hE43ZQJYO+MqEDnDMYZUU9wri8YkK8Q23uQtb+kUYBQz9Q==", "68c7c316-a3aa-46b0-9518-7b2453505788" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd68a836-f988-4dea-af8d-ad33664480af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef1abbbb-cefd-4afb-8157-75cbfc9d7d2d", "AQAAAAIAAYagAAAAEIrvjXssGGjVTtMAJ9cw2xjvMaux71T32RaAQhfPfpbO2Q4ikrw8Qq/ZewH6zAgzvw==", "51c1ee9f-d56d-4c2c-9edf-2dc7865ec47d" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Image", "Percentage" },
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "476fa748-2972-4eb1-9115-42fb735ccd88", "AQAAAAIAAYagAAAAEGg4RbNGxLmjlBa8CZv+hAbCbugambjs6Vlz8SjBySKSGl/nuIWI73IWzfVLWpFztg==", "250504dd-1484-4eb7-ab52-5bcb7b66ead5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd68a836-f988-4dea-af8d-ad33664480af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af39a72-3b33-4b7d-b566-d5bf0878fea0", "AQAAAAIAAYagAAAAEIAkK1YrgxTbeN8dbK3JKTsvfPVqEVsikNtJL9Vak24t8ZkdDYjnfoUUsmjhFVwj/w==", "277da621-7137-4bce-933e-e84c0d23c698" });
        }
    }
}