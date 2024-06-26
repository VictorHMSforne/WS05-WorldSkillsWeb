using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace WS.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClinicaPregressa",
                columns: table => new
                {
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DoencasInfecciosas = table.Column<string>(type: "longtext", nullable: false),
                    Alergias = table.Column<string>(type: "longtext", nullable: false),
                    Cirurgias = table.Column<string>(type: "longtext", nullable: false),
                    TransfusaoSangue = table.Column<string>(type: "longtext", nullable: false),
                    MedicamentosContinuo = table.Column<string>(type: "longtext", nullable: false),
                    Outros = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicaPregressa", x => x.MyProperty);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExameClinico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ocupacao = table.Column<string>(type: "longtext", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false),
                    Idade = table.Column<string>(type: "longtext", nullable: false),
                    RG = table.Column<string>(type: "longtext", nullable: false),
                    Funcao = table.Column<string>(type: "longtext", nullable: false),
                    Empresa = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExameClinico", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HistoricoOcupacional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FuncoesAnteriores = table.Column<string>(type: "longtext", nullable: false),
                    AcidentesTrabalho = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoOcupacional", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClinicaPregressa");

            migrationBuilder.DropTable(
                name: "ExameClinico");

            migrationBuilder.DropTable(
                name: "HistoricoOcupacional");
        }
    }
}
