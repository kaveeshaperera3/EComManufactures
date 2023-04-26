using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComManufactures.Data.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Catagory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatagoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardDisk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HardDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HardPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDisk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdersStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessorTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessorDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessorPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RamTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RamPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopingCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopingCart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VirusGuard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VirusTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VirusPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirusGuard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_OrdersStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrdersStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    ComputerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerTitle = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ComputerBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerSeries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerRam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerHard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerGraphic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerWarrenty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerPrice = table.Column<double>(type: "float", nullable: false),
                    ComputerImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatagoryID = table.Column<int>(type: "int", nullable: false),
                    RamID = table.Column<int>(type: "int", nullable: false),
                    ProcessorID = table.Column<int>(type: "int", nullable: false),
                    HardID = table.Column<int>(type: "int", nullable: false),
                    VirusID = table.Column<int>(type: "int", nullable: false),
                    VirusGuardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computer", x => x.ComputerId);
                    table.ForeignKey(
                        name: "FK_Computer_Catagory_CatagoryID",
                        column: x => x.CatagoryID,
                        principalTable: "Catagory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_HardDisk_HardID",
                        column: x => x.HardID,
                        principalTable: "HardDisk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_Processor_ProcessorID",
                        column: x => x.ProcessorID,
                        principalTable: "Processor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_Ram_RamID",
                        column: x => x.RamID,
                        principalTable: "Ram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_VirusGuard_VirusGuardId",
                        column: x => x.VirusGuardId,
                        principalTable: "VirusGuard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false),
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetail_Computer_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computer",
                        principalColumn: "ComputerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetail_ShopingCart_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShopingCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Computer_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computer",
                        principalColumn: "ComputerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetail_ComputerId",
                table: "CartDetail",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetail_ShoppingCartId",
                table: "CartDetail",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_CatagoryID",
                table: "Computer",
                column: "CatagoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_HardID",
                table: "Computer",
                column: "HardID");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_ProcessorID",
                table: "Computer",
                column: "ProcessorID");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_RamID",
                table: "Computer",
                column: "RamID");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_VirusGuardId",
                table: "Computer",
                column: "VirusGuardId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderStatusId",
                table: "Order",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ComputerId",
                table: "OrderDetail",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartDetail");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ShopingCart");

            migrationBuilder.DropTable(
                name: "Computer");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Catagory");

            migrationBuilder.DropTable(
                name: "HardDisk");

            migrationBuilder.DropTable(
                name: "Processor");

            migrationBuilder.DropTable(
                name: "Ram");

            migrationBuilder.DropTable(
                name: "VirusGuard");

            migrationBuilder.DropTable(
                name: "OrdersStatus");

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
        }
    }
}
