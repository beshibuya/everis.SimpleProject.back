using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class Projeto_Siglas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Siglas_SiglaId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_SiglaId",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "SiglaId",
                table: "Projetos");

            migrationBuilder.CreateTable(
                name: "ProjetosSiglas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    ProjetoId = table.Column<int>(nullable: false),
                    SiglaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetosSiglas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjetosSiglas_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjetosSiglas_Siglas_SiglaId",
                        column: x => x.SiglaId,
                        principalTable: "Siglas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjetosSiglas_ProjetoId",
                table: "ProjetosSiglas",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetosSiglas_SiglaId",
                table: "ProjetosSiglas",
                column: "SiglaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjetosSiglas");

            migrationBuilder.AddColumn<int>(
                name: "SiglaId",
                table: "Projetos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_SiglaId",
                table: "Projetos",
                column: "SiglaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Siglas_SiglaId",
                table: "Projetos",
                column: "SiglaId",
                principalTable: "Siglas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
