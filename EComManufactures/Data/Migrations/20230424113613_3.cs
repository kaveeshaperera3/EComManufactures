﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComManufactures.Data.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VirusID",
                table: "Computer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VirusID",
                table: "Computer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
