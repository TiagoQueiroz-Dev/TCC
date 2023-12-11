using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    /// <inheritdoc />
    public partial class cepUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cep",
                table: "Notas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "MEDIUMINT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cep",
                table: "Notas",
                type: "MEDIUMINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
