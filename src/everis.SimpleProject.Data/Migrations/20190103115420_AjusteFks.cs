using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AjusteFks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anexos_Projetos_ProjetoId",
                table: "Anexos");

            migrationBuilder.DropForeignKey(
                name: "FK_Changes_Projetos_ProjetoId",
                table: "Changes");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradors_Pessoas_PessoaId",
                table: "Colaboradors");

            migrationBuilder.DropForeignKey(
                name: "FK_EsforcoProjetos_ProjetoPessoas_ProjetoPessoaId",
                table: "EsforcoProjetos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoPessoaAtribuicoes_ProjetoPessoas_ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoPessoas_Pessoas_PessoaId",
                table: "ProjetoPessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoPessoas_Projetos_ProjetoId",
                table: "ProjetoPessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Empresas_EmpresaId",
                table: "Projetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_ProjetoPessoas_ProjetoId",
                table: "ProjetoPessoas");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeUsuario",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumeroTelefone",
                table: "Telefones",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EscopoProjeto",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CentroCusto",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaId1",
                table: "ProjetoPessoas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicio",
                table: "EsforcoProjetos",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Empresas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailCorporativo",
                table: "Colaboradors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Changes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "Anexos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Anexos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_PessoaId1",
                table: "ProjetoPessoas",
                column: "PessoaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Anexos_Projetos_ProjetoId",
                table: "Anexos",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Changes_Projetos_ProjetoId",
                table: "Changes",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradors_Pessoas_PessoaId",
                table: "Colaboradors",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EsforcoProjetos_ProjetoPessoas_ProjetoPessoaId",
                table: "EsforcoProjetos",
                column: "ProjetoPessoaId",
                principalTable: "ProjetoPessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoPessoaAtribuicoes_ProjetoPessoas_ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes",
                column: "ProjetoPessoaId",
                principalTable: "ProjetoPessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoPessoas_Projetos_PessoaId",
                table: "ProjetoPessoas",
                column: "PessoaId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoPessoas_Pessoas_PessoaId1",
                table: "ProjetoPessoas",
                column: "PessoaId1",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Empresas_EmpresaId",
                table: "Projetos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anexos_Projetos_ProjetoId",
                table: "Anexos");

            migrationBuilder.DropForeignKey(
                name: "FK_Changes_Projetos_ProjetoId",
                table: "Changes");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradors_Pessoas_PessoaId",
                table: "Colaboradors");

            migrationBuilder.DropForeignKey(
                name: "FK_EsforcoProjetos_ProjetoPessoas_ProjetoPessoaId",
                table: "EsforcoProjetos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoPessoaAtribuicoes_ProjetoPessoas_ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoPessoas_Projetos_PessoaId",
                table: "ProjetoPessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoPessoas_Pessoas_PessoaId1",
                table: "ProjetoPessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Empresas_EmpresaId",
                table: "Projetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_ProjetoPessoas_PessoaId1",
                table: "ProjetoPessoas");

            migrationBuilder.DropColumn(
                name: "PessoaId1",
                table: "ProjetoPessoas");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "NomeUsuario",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NumeroTelefone",
                table: "Telefones",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EscopoProjeto",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CentroCusto",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicio",
                table: "EsforcoProjetos",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Empresas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EmailCorporativo",
                table: "Colaboradors",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Changes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "Anexos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Anexos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_ProjetoId",
                table: "ProjetoPessoas",
                column: "ProjetoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anexos_Projetos_ProjetoId",
                table: "Anexos",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Changes_Projetos_ProjetoId",
                table: "Changes",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradors_Pessoas_PessoaId",
                table: "Colaboradors",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EsforcoProjetos_ProjetoPessoas_ProjetoPessoaId",
                table: "EsforcoProjetos",
                column: "ProjetoPessoaId",
                principalTable: "ProjetoPessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoPessoaAtribuicoes_ProjetoPessoas_ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes",
                column: "ProjetoPessoaId",
                principalTable: "ProjetoPessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoPessoas_Pessoas_PessoaId",
                table: "ProjetoPessoas",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoPessoas_Projetos_ProjetoId",
                table: "ProjetoPessoas",
                column: "ProjetoId",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Empresas_EmpresaId",
                table: "Projetos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
