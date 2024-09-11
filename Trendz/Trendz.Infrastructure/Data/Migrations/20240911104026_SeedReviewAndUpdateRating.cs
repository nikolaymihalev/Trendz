using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trendz.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedReviewAndUpdateRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "RatingId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Rating identifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Men");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Women");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "PublishDate", "RatingId", "UserId" },
                values: new object[] { 1, "Super cute for a party. True to size, it's a bit thin but still good quality, felt super comfortabcomfortable.", 1, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "bd68a836-f988-4dea-af8d-ad33664480af" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RatingId",
                table: "Reviews",
                column: "RatingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Ratings_RatingId",
                table: "Reviews",
                column: "RatingId",
                principalTable: "Ratings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Ratings_RatingId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_RatingId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "RatingId",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Review rating");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Men T-Shirts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Women T-Shirts");
        }
    }
}
