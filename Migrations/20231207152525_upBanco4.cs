using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    /// <inheritdoc />
    public partial class upBanco4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorPag",
                table: "Notas",
                newName: "ValorPago");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorPago",
                table: "Notas",
                newName: "ValorPag");
        }
    }
}
