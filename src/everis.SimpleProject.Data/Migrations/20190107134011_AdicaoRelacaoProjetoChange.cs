using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AdicaoRelacaoProjetoChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjetoId1",
                table: "Changes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Changes_ProjetoId1",
                table: "Changes",
                column: "ProjetoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Changes_Projetos_ProjetoId1",
                table: "Changes",
                column: "ProjetoId1",
                principalTable: "Projetos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Changes_Projetos_ProjetoId1",
                table: "Changes");

            migrationBuilder.DropIndex(
                name: "IX_Changes_ProjetoId1",
                table: "Changes");

            migrationBuilder.DropColumn(
                name: "ProjetoId1",
                table: "Changes");
        }
    }
}
