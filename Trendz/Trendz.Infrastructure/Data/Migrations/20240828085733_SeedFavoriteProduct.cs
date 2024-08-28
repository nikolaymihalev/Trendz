using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trendz.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedFavoriteProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Favorite product identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product identifier"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "User favorite product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "694655b4-1574-4f94-90ca-92312ea295a7", "AQAAAAIAAYagAAAAEMOSyNNimzogMbzpDSlr6Nz+aE5M4QFpMWYyfC39Jx+3FjI01TZn3nJSXMA3ZOX9Fg==", "14944817-c124-4b9d-a330-2ffe7eca47b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd68a836-f988-4dea-af8d-ad33664480af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87402849-288a-4cb4-8242-d4fb5d1c58b2", "AQAAAAIAAYagAAAAEHTXM/Xx3B8/gjS5MR82IV8Zx7tuL2STHOfHmMNg0C5td7t+lXZJNo5K0R0uGvjsKw==", "74a4930b-593b-4491-9f2f-9a86d89f9b0a" });

            migrationBuilder.InsertData(
                table: "FavoriteProducts",
                columns: new[] { "Id", "ProductId", "UserId" },
                values: new object[] { 1, 1, "bd68a836-f988-4dea-af8d-ad33664480af" });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_ProductId",
                table: "FavoriteProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_UserId",
                table: "FavoriteProducts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteProducts");

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
        }
    }
}
