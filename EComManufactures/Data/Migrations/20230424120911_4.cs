using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComManufactures.Data.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComputerImgUrl",
                table: "Computer",
                newName: "ComputerImgUrl3");

            migrationBuilder.AddColumn<string>(
                name: "ComputerImgUrl1",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComputerImgUrl2",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComputerImgUrl1",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "ComputerImgUrl2",
                table: "Computer");

            migrationBuilder.RenameColumn(
                name: "ComputerImgUrl3",
                table: "Computer",
                newName: "ComputerImgUrl");
        }
    }
}
