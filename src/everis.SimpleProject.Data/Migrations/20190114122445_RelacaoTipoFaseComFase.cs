using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class RelacaoTipoFaseComFase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodigoFase",
                table: "Fases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Fases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoFaseId",
                table: "Fases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fases_TipoFaseId",
                table: "Fases",
                column: "TipoFaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fases_TiposFases_TipoFaseId",
                table: "Fases",
                column: "TipoFaseId",
                principalTable: "TiposFases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fases_TiposFases_TipoFaseId",
                table: "Fases");

            migrationBuilder.DropIndex(
                name: "IX_Fases_TipoFaseId",
                table: "Fases");

            migrationBuilder.DropColumn(
                name: "CodigoFase",
                table: "Fases");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Fases");

            migrationBuilder.DropColumn(
                name: "TipoFaseId",
                table: "Fases");
        }
    }
}
