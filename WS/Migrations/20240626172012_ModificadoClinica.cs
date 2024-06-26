using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WS.Migrations
{
    /// <inheritdoc />
    public partial class ModificadoClinica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Outros",
                table: "ClinicaPregressa",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Outros",
                table: "ClinicaPregressa",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);
        }
    }
}
