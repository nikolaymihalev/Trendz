using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Trendz.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedInventoryItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Size identifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a2f5f65-997e-46a4-b046-6e512d0a35e3", "AQAAAAIAAYagAAAAEAUvHwAJACNPvNR5P5tyAuRapPYDc5zHGULnB8nDcELDzv+Q4A3qPc8jqxX5NLwnuA==", "a3ec0a27-0c08-49b7-9686-20129adeba55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd68a836-f988-4dea-af8d-ad33664480af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52f64a72-f904-4c41-b56e-0aa1322e7a92", "AQAAAAIAAYagAAAAEJ4u+YMTs0ulXfH6cLXtuBt2jdNmI9PoQ37p8gIBqCTBobhPzinD6uqVZrbuxUkHcw==", "7ca15485-e283-438a-9b0d-af9a46301c49" });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "ProductId", "QuantityInStock", "SizeId", "WarehouseLocation" },
                values: new object[,]
                {
                    { 1, 1, 3, 1, "" },
                    { 2, 1, 5, 2, "" }
                });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "S");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_SizeId",
                table: "Inventories",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Sizes_SizeId",
                table: "Inventories",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Sizes_SizeId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_SizeId",
                table: "Inventories");

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Inventories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e1c54e-cc2b-4c09-8678-b0fba336e522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61dc271f-48af-451a-ad4c-db0608bda457", "AQAAAAIAAYagAAAAEKQVuqKuV3EJbzjvJuR5kILZFLQWK9Ul0gJQJFc1MCtNUpGc9uxW+pn959AYZVDLfg==", "0dd81a74-24a3-482d-8680-ee32de4caaa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd68a836-f988-4dea-af8d-ad33664480af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4552d199-bc4e-453d-aa85-ab526387656f", "AQAAAAIAAYagAAAAEMBgddi0L9QFZ1QtRuvrCSQ7FromLIIr1kyfFAL5ScfNsNbkhmYfge8y9Cjwkg48ZA==", "4911b89b-b0e4-45ac-98d2-a0eb289b30db" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "M Size");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "S Size");
        }
    }
}
