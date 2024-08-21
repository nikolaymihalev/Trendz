using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trendz.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Rating identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product identifier"),
                    Value = table.Column<double>(type: "float", nullable: false, comment: "Rating value")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ProductId", "UserId", "Value" },
                values: new object[] { 1, 1, "bd68a836-f988-4dea-af8d-ad33664480af", 5.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ProductId",
                table: "Ratings",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d125ede-212c-4293-a629-6fda6aa8707c", "AQAAAAIAAYagAAAAEBM3bP27HoIxYWwnzxq2McE4aiTfZ8WtAuKfdAjbtVnmxvnb9cLiQVJYCT3fDJDj4g==", "fa5c34f8-6c00-4c8b-a3d6-ae893959ebef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd68a836-f988-4dea-af8d-ad33664480af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "708cd809-297a-4143-b757-9e2f5c8e10cf", "AQAAAAIAAYagAAAAENFNp0t9UEKFYrpiB9+o/5geKwHPpUQKEjdV5lFIQDX2N0YI4EgmzNvGnej+JtDaOg==", "992404d1-b294-4662-9cc1-9724d24df868" });
        }
    }
}
