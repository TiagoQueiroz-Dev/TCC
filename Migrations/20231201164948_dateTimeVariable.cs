using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    /// <inheritdoc />
    public partial class dateTimeVariable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataRecolhimento",
                table: "Notas",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataEmissao",
                table: "Notas",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DataRecolhimento",
                table: "Notas",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AlterColumn<int>(
                name: "DataEmissao",
                table: "Notas",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");
        }
    }
}
