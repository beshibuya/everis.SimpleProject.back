using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class RelacionamentoStatusProjeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CodigoProjeto",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Projetos",
                nullable: true,
                defaultValueSql: "1");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_StatusId",
                table: "Projetos",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Status_StatusId",
                table: "Projetos",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Status_StatusId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_StatusId",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Projetos");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoProjeto",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
