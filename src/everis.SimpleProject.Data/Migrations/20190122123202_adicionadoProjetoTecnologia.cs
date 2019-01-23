using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class adicionadoProjetoTecnologia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TecnologiaId",
                table: "Projetos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tecnologia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoTecnologia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    ProjetoId = table.Column<int>(nullable: false),
                    TecnologiaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoTecnologia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjetoTecnologia_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjetoTecnologia_Tecnologia_TecnologiaId",
                        column: x => x.TecnologiaId,
                        principalTable: "Tecnologia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoTecnologia_ProjetoId",
                table: "ProjetoTecnologia",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoTecnologia_TecnologiaId",
                table: "ProjetoTecnologia",
                column: "TecnologiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjetoTecnologia");

            migrationBuilder.DropTable(
                name: "Tecnologia");

            migrationBuilder.DropColumn(
                name: "TecnologiaId",
                table: "Projetos");
        }
    }
}
