using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComManufactures.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computer_HardDisk_HardID",
                table: "Computer");

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Processor_ProcessorID",
                table: "Computer");

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Ram_RamID",
                table: "Computer");

            migrationBuilder.DropIndex(
                name: "IX_Computer_HardID",
                table: "Computer");

            migrationBuilder.DropIndex(
                name: "IX_Computer_ProcessorID",
                table: "Computer");

            migrationBuilder.DropIndex(
                name: "IX_Computer_RamID",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "HardID",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "ProcessorID",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "RamID",
                table: "Computer");

            migrationBuilder.AddColumn<int>(
                name: "HardID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProcessorID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RamID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VirusGuardId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VirusID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_HardID",
                table: "OrderDetail",
                column: "HardID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProcessorID",
                table: "OrderDetail",
                column: "ProcessorID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_RamID",
                table: "OrderDetail",
                column: "RamID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_VirusGuardId",
                table: "OrderDetail",
                column: "VirusGuardId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_HardDisk_HardID",
                table: "OrderDetail",
                column: "HardID",
                principalTable: "HardDisk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Processor_ProcessorID",
                table: "OrderDetail",
                column: "ProcessorID",
                principalTable: "Processor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Ram_RamID",
                table: "OrderDetail",
                column: "RamID",
                principalTable: "Ram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_VirusGuard_VirusGuardId",
                table: "OrderDetail",
                column: "VirusGuardId",
                principalTable: "VirusGuard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_HardDisk_HardID",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Processor_ProcessorID",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Ram_RamID",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_VirusGuard_VirusGuardId",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_HardID",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_ProcessorID",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_RamID",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_VirusGuardId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "HardID",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ProcessorID",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "RamID",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "VirusGuardId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "VirusID",
                table: "OrderDetail");

            migrationBuilder.AddColumn<int>(
                name: "HardID",
                table: "Computer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProcessorID",
                table: "Computer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RamID",
                table: "Computer",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_HardDisk_HardID",
                table: "Computer",
                column: "HardID",
                principalTable: "HardDisk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_Processor_ProcessorID",
                table: "Computer",
                column: "ProcessorID",
                principalTable: "Processor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_Ram_RamID",
                table: "Computer",
                column: "RamID",
                principalTable: "Ram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
