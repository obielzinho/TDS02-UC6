using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstacionamentoSenac.API.Migrations
{
    /// <inheritdoc />
    public partial class updateVeiculoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motoristas_Veiculos_VeiculoId1",
                table: "Motoristas");

            migrationBuilder.DropIndex(
                name: "IX_Motoristas_VeiculoId1",
                table: "Motoristas");

            migrationBuilder.DropColumn(
                name: "VeiculoId1",
                table: "Motoristas");

            migrationBuilder.AlterColumn<int>(
                name: "VeiculoId",
                table: "Motoristas",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_VeiculoId",
                table: "Motoristas",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Motoristas_Veiculos_VeiculoId",
                table: "Motoristas",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motoristas_Veiculos_VeiculoId",
                table: "Motoristas");

            migrationBuilder.DropIndex(
                name: "IX_Motoristas_VeiculoId",
                table: "Motoristas");

            migrationBuilder.AlterColumn<string>(
                name: "VeiculoId",
                table: "Motoristas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoId1",
                table: "Motoristas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_VeiculoId1",
                table: "Motoristas",
                column: "VeiculoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Motoristas_Veiculos_VeiculoId1",
                table: "Motoristas",
                column: "VeiculoId1",
                principalTable: "Veiculos",
                principalColumn: "Id");
        }
    }
}
