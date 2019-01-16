using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AlteracaoFases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fases_ProjetoPessoas_ProjetoPessoaId",
                table: "Fases");

            migrationBuilder.RenameColumn(
                name: "ProjetoPessoaId",
                table: "Fases",
                newName: "ProjetoId");

            migrationBuilder.RenameIndex(
                name: "IX_Fases_ProjetoPessoaId",
                table: "Fases",
                newName: "IX_Fases_ProjetoId");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Fases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fases_PessoaId",
                table: "Fases",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fases_Pessoas_PessoaId",
                table: "Fases",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fases_Projetos_ProjetoId",
                table: "Fases",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fases_Pessoas_PessoaId",
                table: "Fases");

            migrationBuilder.DropForeignKey(
                name: "FK_Fases_Projetos_ProjetoId",
                table: "Fases");

            migrationBuilder.DropIndex(
                name: "IX_Fases_PessoaId",
                table: "Fases");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Fases");

            migrationBuilder.RenameColumn(
                name: "ProjetoId",
                table: "Fases",
                newName: "ProjetoPessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Fases_ProjetoId",
                table: "Fases",
                newName: "IX_Fases_ProjetoPessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fases_ProjetoPessoas_ProjetoPessoaId",
                table: "Fases",
                column: "ProjetoPessoaId",
                principalTable: "ProjetoPessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
