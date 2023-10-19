using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Migrations
{
    /// <inheritdoc />
    public partial class deploy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstoqueGeral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuantidadeTotal = table.Column<int>(type: "int", nullable: false),
                    Alugados = table.Column<int>(type: "int", nullable: false),
                    Disponiveis = table.Column<int>(type: "int", nullable: false),
                    ValorUnid = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueGeral", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Andaimes_10 = table.Column<int>(type: "int", nullable: false),
                    Andaimes_13 = table.Column<int>(type: "int", nullable: false),
                    Andaimes_15 = table.Column<int>(type: "int", nullable: false),
                    Andaimes_20 = table.Column<int>(type: "int", nullable: false),
                    Bitoneira = table.Column<int>(type: "int", nullable: false),
                    Escora_35 = table.Column<int>(type: "int", nullable: false),
                    Escora_50 = table.Column<int>(type: "int", nullable: false),
                    Pe_Regulador = table.Column<int>(type: "int", nullable: false),
                    Lastro_10 = table.Column<int>(type: "int", nullable: false),
                    Lastro_15 = table.Column<int>(type: "int", nullable: false),
                    Lastro_20 = table.Column<int>(type: "int", nullable: false),
                    Pranchao = table.Column<int>(type: "int", nullable: false),
                    Rodanas = table.Column<int>(type: "int", nullable: false),
                    Travas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstoqueGeral");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
