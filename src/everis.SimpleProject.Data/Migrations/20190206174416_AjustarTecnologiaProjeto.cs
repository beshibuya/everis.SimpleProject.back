using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AjustarTecnologiaProjeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Tecnologia_TecnologiaId",
                table: "Projetos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_TecnologiaId",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "TecnologiaId",
                table: "Projetos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TecnologiaId",
                table: "Projetos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    NomeUsuario = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(maxLength: 255, nullable: false),
                    SenhaTemporaria = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_TecnologiaId",
                table: "Projetos",
                column: "TecnologiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Tecnologia_TecnologiaId",
                table: "Projetos",
                column: "TecnologiaId",
                principalTable: "Tecnologia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
