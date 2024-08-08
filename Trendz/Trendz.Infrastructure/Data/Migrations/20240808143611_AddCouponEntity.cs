using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trendz.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCouponEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Coupon identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentage = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false, comment: "Coupon percentage"),
                    Image = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false, comment: "Coupon image file")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                },
                comment: "Coupon entity");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08688f74-b266-40d9-88d6-ffedef312ca3", "AQAAAAIAAYagAAAAENvOuXSzk8FtWumZzDlgE4y9KtdBcU79xEaYa1HyIivMzvcIMGzaC9Q864/CkP60lA==", "51a36b07-d70e-4509-a081-748f64c7109a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd68a836-f988-4dea-af8d-ad33664480af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be8a35be-b707-49d5-b0a4-543f9af91040", "AQAAAAIAAYagAAAAEKz/ZLjJYrKue1t6plnpKqtLMJKT8MOnTkipMUjiKAGdnajV1STurM2upmwqkgMEeg==", "b4ed00b5-ce9e-4a26-bfbf-e0ab4fdb4d00" });
        }
    }
}
