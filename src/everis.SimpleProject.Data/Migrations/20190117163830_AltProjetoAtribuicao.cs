using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AltProjetoAtribuicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoPessoaAtribuicoes_ProjetoPessoas_ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes");

            migrationBuilder.DropIndex(
                name: "IX_ProjetoPessoaAtribuicoes_ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes");

            migrationBuilder.DropColumn(
                name: "ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes");

            migrationBuilder.AddColumn<int>(
                name: "AtribuicaoId",
                table: "ProjetoPessoas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Responsavel",
                table: "ProjetoPessoas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Atribuicao",
                table: "ProjetoPessoaAtribuicoes",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_AtribuicaoId",
                table: "ProjetoPessoas",
                column: "AtribuicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoPessoas_ProjetoPessoaAtribuicoes_AtribuicaoId",
                table: "ProjetoPessoas",
                column: "AtribuicaoId",
                principalTable: "ProjetoPessoaAtribuicoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoPessoas_ProjetoPessoaAtribuicoes_AtribuicaoId",
                table: "ProjetoPessoas");

            migrationBuilder.DropIndex(
                name: "IX_ProjetoPessoas_AtribuicaoId",
                table: "ProjetoPessoas");

            migrationBuilder.DropColumn(
                name: "AtribuicaoId",
                table: "ProjetoPessoas");

            migrationBuilder.DropColumn(
                name: "Responsavel",
                table: "ProjetoPessoas");

            migrationBuilder.AlterColumn<int>(
                name: "Atribuicao",
                table: "ProjetoPessoaAtribuicoes",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoaAtribuicoes_ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes",
                column: "ProjetoPessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoPessoaAtribuicoes_ProjetoPessoas_ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes",
                column: "ProjetoPessoaId",
                principalTable: "ProjetoPessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
