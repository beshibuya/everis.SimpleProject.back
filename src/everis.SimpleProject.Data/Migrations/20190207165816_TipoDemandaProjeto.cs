using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class TipoDemandaProjeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoDemandas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDemandas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjetosTipoDemanda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    ProjetoId = table.Column<int>(nullable: false),
                    TipoDemandaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetosTipoDemanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjetosTipoDemanda_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjetosTipoDemanda_TipoDemandas_TipoDemandaId",
                        column: x => x.TipoDemandaId,
                        principalTable: "TipoDemandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjetosTipoDemanda_ProjetoId",
                table: "ProjetosTipoDemanda",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetosTipoDemanda_TipoDemandaId",
                table: "ProjetosTipoDemanda",
                column: "TipoDemandaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjetosTipoDemanda");

            migrationBuilder.DropTable(
                name: "TipoDemandas");
        }
    }
}
