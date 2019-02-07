using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class ProjetExts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ext",
                table: "Projetos");

            migrationBuilder.AddColumn<int>(
                name: "ExtId",
                table: "Projetos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_ExtId",
                table: "Projetos",
                column: "ExtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Exts_ExtId",
                table: "Projetos",
                column: "ExtId",
                principalTable: "Exts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Exts_ExtId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_ExtId",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "ExtId",
                table: "Projetos");

            migrationBuilder.AddColumn<string>(
                name: "Ext",
                table: "Projetos",
                nullable: true);
        }
    }
}
