using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class RemoçãoIdsduplicadoanoprojetopessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoPessoas_Projetos_ProjetoId1",
                table: "ProjetoPessoas");

            migrationBuilder.DropIndex(
                name: "IX_ProjetoPessoas_ProjetoId1",
                table: "ProjetoPessoas");

            migrationBuilder.DropColumn(
                name: "ProjetoId1",
                table: "ProjetoPessoas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjetoId1",
                table: "ProjetoPessoas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_ProjetoId1",
                table: "ProjetoPessoas",
                column: "ProjetoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoPessoas_Projetos_ProjetoId1",
                table: "ProjetoPessoas",
                column: "ProjetoId1",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
