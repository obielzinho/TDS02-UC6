using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovoEstacionamento.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoClienteVeiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cor",
                table: "Veiculos",
                newName: "cores");

            migrationBuilder.AddColumn<string>(
                name: "Apelido",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apelido",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "cores",
                table: "Veiculos",
                newName: "cor");
        }
    }
}
