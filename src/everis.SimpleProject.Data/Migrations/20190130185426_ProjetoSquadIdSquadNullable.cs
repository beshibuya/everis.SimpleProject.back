using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class ProjetoSquadIdSquadNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoSquads_Squads_SquadId",
                table: "ProjetoSquads");

            migrationBuilder.AlterColumn<int>(
                name: "SquadId",
                table: "ProjetoSquads",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoSquads_Squads_SquadId",
                table: "ProjetoSquads",
                column: "SquadId",
                principalTable: "Squads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjetoSquads_Squads_SquadId",
                table: "ProjetoSquads");

            migrationBuilder.AlterColumn<int>(
                name: "SquadId",
                table: "ProjetoSquads",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjetoSquads_Squads_SquadId",
                table: "ProjetoSquads",
                column: "SquadId",
                principalTable: "Squads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
