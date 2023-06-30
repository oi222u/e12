using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CreatedAt" },
                values: new object[] { 1, "teste", new DateTime(2023, 6, 9, 22, 41, 20, 859, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "Password" },
                values: new object[] { 1, new DateTime(2023, 6, 9, 22, 41, 20, 859, DateTimeKind.Local).AddTicks(5562), "aaa", "aaa", "aaa" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Name", "UserId" },
                values: new object[] { 1, new DateTime(2023, 6, 10, 1, 41, 20, 859, DateTimeKind.Utc).AddTicks(5779), "aaa", 1 });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Country", "CreatedAt", "Description", "Name", "ProductCatalogCount", "UserId" },
                values: new object[] { 1, "aaaa", new DateTime(2023, 6, 9, 22, 41, 20, 859, DateTimeKind.Local).AddTicks(5825), "dqwdwqdwq", "aaa", 0, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "ProductCategoryId", "SoldAmount", "StoreId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 9, 22, 41, 20, 859, DateTimeKind.Local).AddTicks(5862), "fodasi", "product 1", 2131321m, 1, 0, 1 },
                    { 2, new DateTime(2023, 6, 9, 22, 41, 20, 859, DateTimeKind.Local).AddTicks(5968), "qweqweqwe", "product 2", 3211m, 1, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "LargeImagePath", "Name", "ProductId", "SmallImagePath", "UserId" },
                values: new object[,]
                {
                    { 1, "/images/products/large/f02abd23-725c-4a22-8c33-d7cc6fc8ace6.jpg", "dqwdqwdqwd", 1, "/images/products/small/e3f6409f-e503-4518-97b1-2a13d749e930.jpg", 1 },
                    { 2, "/images/products/large/755e2f80-9ae0-4876-b0cd-4f543e478d82.jpg", "qeqwffqfwqq", 2, "/images/products/small/9bb05481-651f-46f7-acc8-ac581f467337.jpg", 1 },
                    { 3, "/images/products/large/7255f057-1e16-42b5-8370-73fff43db85e.webp", "dqwdqwdqwd", 2, "/images/products/small/a90032c7-cf6f-44da-8fe0-f824b14dff74.webp", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
