using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class adm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bouquets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BouquetName = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bouquets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flowers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowerName = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packagings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(nullable: false),
                    PackagingName = table.Column<string>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packagings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestName = table.Column<string>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BouquetId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Sum = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DateImplement = table.Column<DateTime>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Bouquets_BouquetId",
                        column: x => x.BouquetId,
                        principalTable: "Bouquets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlowerBouquets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BouquetId = table.Column<int>(nullable: false),
                    FlowerId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerBouquets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowerBouquets_Bouquets_BouquetId",
                        column: x => x.BouquetId,
                        principalTable: "Bouquets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowerBouquets_Flowers_FlowerId",
                        column: x => x.FlowerId,
                        principalTable: "Flowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackagingBouquets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BouquetId = table.Column<int>(nullable: false),
                    PackagingId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingBouquets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackagingBouquets_Bouquets_BouquetId",
                        column: x => x.BouquetId,
                        principalTable: "Bouquets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackagingBouquets_Packagings_PackagingId",
                        column: x => x.PackagingId,
                        principalTable: "Packagings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestsFlowers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<int>(nullable: false),
                    FlowerId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestsFlowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestsFlowers_Flowers_FlowerId",
                        column: x => x.FlowerId,
                        principalTable: "Flowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestsFlowers_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowerBouquets_BouquetId",
                table: "FlowerBouquets",
                column: "BouquetId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowerBouquets_FlowerId",
                table: "FlowerBouquets",
                column: "FlowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BouquetId",
                table: "Orders",
                column: "BouquetId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingBouquets_BouquetId",
                table: "PackagingBouquets",
                column: "BouquetId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagingBouquets_PackagingId",
                table: "PackagingBouquets",
                column: "PackagingId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestsFlowers_FlowerId",
                table: "RequestsFlowers",
                column: "FlowerId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestsFlowers_RequestId",
                table: "RequestsFlowers",
                column: "RequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowerBouquets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PackagingBouquets");

            migrationBuilder.DropTable(
                name: "RequestsFlowers");

            migrationBuilder.DropTable(
                name: "Bouquets");

            migrationBuilder.DropTable(
                name: "Packagings");

            migrationBuilder.DropTable(
                name: "Flowers");

            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
