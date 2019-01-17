using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AddPropPessoas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExclusivoItau",
                table: "Colaboradors",
                newName: "ExclusivoCliente");

            migrationBuilder.RenameColumn(
                name: "DataAdmissão",
                table: "Colaboradors",
                newName: "DataAdmissao");

            migrationBuilder.AddColumn<bool>(
                name: "GestorTecnico",
                table: "Pessoas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "GestorTecnicoCliente",
                table: "Colaboradors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GestorTecnico",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "GestorTecnicoCliente",
                table: "Colaboradors");

            migrationBuilder.RenameColumn(
                name: "ExclusivoCliente",
                table: "Colaboradors",
                newName: "ExclusivoItau");

            migrationBuilder.RenameColumn(
                name: "DataAdmissao",
                table: "Colaboradors",
                newName: "DataAdmissão");
        }
    }
}
