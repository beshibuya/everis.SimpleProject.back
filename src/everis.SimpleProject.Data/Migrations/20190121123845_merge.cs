using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class merge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diretoria",
                table: "Projetos");

            migrationBuilder.RenameColumn(
                name: "Fase",
                table: "Projetos",
                newName: "DiretoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_DiretoriaId",
                table: "Projetos",
                column: "DiretoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_DiretoriasContratantes_DiretoriaId",
                table: "Projetos",
                column: "DiretoriaId",
                principalTable: "DiretoriasContratantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_DiretoriasContratantes_DiretoriaId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_DiretoriaId",
                table: "Projetos");

            migrationBuilder.RenameColumn(
                name: "DiretoriaId",
                table: "Projetos",
                newName: "Fase");

            migrationBuilder.AddColumn<string>(
                name: "Diretoria",
                table: "Projetos",
                nullable: false,
                defaultValue: "");
        }
    }
}
