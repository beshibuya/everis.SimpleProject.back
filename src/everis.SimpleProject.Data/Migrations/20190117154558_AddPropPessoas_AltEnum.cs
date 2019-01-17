using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AddPropPessoas_AltEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradors_DiretoriasContratantes_DiretoriaContratanteId",
                table: "Colaboradors");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradors_DiretoriaContratanteId",
                table: "Colaboradors");

            migrationBuilder.DropColumn(
                name: "DiretoriaContratanteId",
                table: "Colaboradors");

            migrationBuilder.DropColumn(
                name: "Funcao",
                table: "Colaboradors");

            migrationBuilder.RenameColumn(
                name: "TipoTelefone",
                table: "Telefones",
                newName: "TipoId");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Pessoas",
                newName: "TipoId");

            migrationBuilder.RenameColumn(
                name: "Perfil",
                table: "Colaboradors",
                newName: "FuncaoId");

            migrationBuilder.AddColumn<int>(
                name: "DiretoriaId",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Funcoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTelefones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTelefones", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_TipoId",
                table: "Telefones",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_DiretoriaId",
                table: "Pessoas",
                column: "DiretoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_TipoId",
                table: "Pessoas",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradors_FuncaoId",
                table: "Colaboradors",
                column: "FuncaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradors_Funcoes_FuncaoId",
                table: "Colaboradors",
                column: "FuncaoId",
                principalTable: "Funcoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_DiretoriasContratantes_DiretoriaId",
                table: "Pessoas",
                column: "DiretoriaId",
                principalTable: "DiretoriasContratantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_TipoPessoas_TipoId",
                table: "Pessoas",
                column: "TipoId",
                principalTable: "TipoPessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_TipoTelefones_TipoId",
                table: "Telefones",
                column: "TipoId",
                principalTable: "TipoTelefones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradors_Funcoes_FuncaoId",
                table: "Colaboradors");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_DiretoriasContratantes_DiretoriaId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_TipoPessoas_TipoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_TipoTelefones_TipoId",
                table: "Telefones");

            migrationBuilder.DropTable(
                name: "Funcoes");

            migrationBuilder.DropTable(
                name: "Perfis");

            migrationBuilder.DropTable(
                name: "TipoPessoas");

            migrationBuilder.DropTable(
                name: "TipoTelefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_TipoId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_DiretoriaId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_TipoId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradors_FuncaoId",
                table: "Colaboradors");

            migrationBuilder.DropColumn(
                name: "DiretoriaId",
                table: "Pessoas");

            migrationBuilder.RenameColumn(
                name: "TipoId",
                table: "Telefones",
                newName: "TipoTelefone");

            migrationBuilder.RenameColumn(
                name: "TipoId",
                table: "Pessoas",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "FuncaoId",
                table: "Colaboradors",
                newName: "Perfil");

            migrationBuilder.AddColumn<int>(
                name: "DiretoriaContratanteId",
                table: "Colaboradors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Funcao",
                table: "Colaboradors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradors_DiretoriaContratanteId",
                table: "Colaboradors",
                column: "DiretoriaContratanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradors_DiretoriasContratantes_DiretoriaContratanteId",
                table: "Colaboradors",
                column: "DiretoriaContratanteId",
                principalTable: "DiretoriasContratantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
