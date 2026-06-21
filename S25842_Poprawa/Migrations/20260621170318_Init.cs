using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace S25842_Poprawa.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    DeliveryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.DeliveryId);
                    table.ForeignKey(
                        name: "FK_Delivery_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delivery_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDelivery",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDelivery", x => new { x.DeliveryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductDelivery_Delivery_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Delivery",
                        principalColumn: "DeliveryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDelivery_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe" },
                    { 2, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johne", "Dose" },
                    { 3, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johun", "Daoe" }
                });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "DriverId", "FirstName", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { 1, "John", "Do333", "ss24252525" },
                    { 2, "Johnsd", "Do33355", "ss2" },
                    { 3, "Johni", "Do3a33", "s" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "sss", 2m },
                    { 2, "sss", 2m },
                    { 3, "sss", 2m }
                });

            migrationBuilder.InsertData(
                table: "Delivery",
                columns: new[] { "DeliveryId", "CustomerId", "Date", "DriverId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 3, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductDelivery",
                columns: new[] { "DeliveryId", "ProductId", "Amount" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 3 },
                    { 3, 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_CustomerId",
                table: "Delivery",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_DriverId",
                table: "Delivery",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDelivery_ProductId",
                table: "ProductDelivery",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDelivery");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Driver");
        }
    }
}
