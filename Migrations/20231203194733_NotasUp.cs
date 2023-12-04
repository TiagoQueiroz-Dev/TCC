using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    /// <inheritdoc />
    public partial class NotasUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CNPJ",
                table: "Notas",
                newName: "CPF_CNPJ");

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Notas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorDesconto",
                table: "Notas",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorPag",
                table: "Notas",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorTotal",
                table: "Notas",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "ValorDesconto",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "ValorPag",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Notas");

            migrationBuilder.RenameColumn(
                name: "CPF_CNPJ",
                table: "Notas",
                newName: "CNPJ");
        }
    }
}
