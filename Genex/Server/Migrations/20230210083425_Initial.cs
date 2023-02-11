using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Genex.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "aperture", "MotorBike", "Motorbike" },
                    { 2, "camera-slr", "Cars", "Car" },
                    { 3, "calculator", "Mobile Phones", "MobilePhone" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDelete", "IsPublic", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 10, 14, 4, 25, 363, DateTimeKind.Local).AddTicks(4386), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Descripton", "https://bd.gaadicdn.com/processedimages/joye-bike/thunderbolt/640X309/thunderbolt6315ccda73896.jpg?tr=w-360", false, false, 280000m, "Galaxy Motor" },
                    { 2, 2, new DateTime(2023, 2, 10, 14, 4, 25, 363, DateTimeKind.Local).AddTicks(4421), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Descripton", "https://img.freepik.com/free-vector/modern-blue-urban-adventure-suv-vehicle-illustration_1344-205.jpg?w=2000", false, false, 280000m, "Galaxy Car" },
                    { 3, 3, new DateTime(2023, 2, 10, 14, 4, 25, 363, DateTimeKind.Local).AddTicks(4426), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Descripton", "https://m.media-amazon.com/images/I/61l9ppRIiqL._SX466_.jpg", false, false, 280000m, "Galaxy Phone" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
