using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AcessoFerramentas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcessoFerramenta_Colaboradors_ColaboradorId",
                table: "AcessoFerramenta");

            migrationBuilder.DropForeignKey(
                name: "FK_AcessoFerramenta_Ferramenta_FerramentaId",
                table: "AcessoFerramenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ferramenta",
                table: "Ferramenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcessoFerramenta",
                table: "AcessoFerramenta");

            migrationBuilder.RenameTable(
                name: "Ferramenta",
                newName: "Ferramentas");

            migrationBuilder.RenameTable(
                name: "AcessoFerramenta",
                newName: "AcessoFerramentas");

            migrationBuilder.RenameIndex(
                name: "IX_AcessoFerramenta_FerramentaId",
                table: "AcessoFerramentas",
                newName: "IX_AcessoFerramentas_FerramentaId");

            migrationBuilder.RenameIndex(
                name: "IX_AcessoFerramenta_ColaboradorId",
                table: "AcessoFerramentas",
                newName: "IX_AcessoFerramentas_ColaboradorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ferramentas",
                table: "Ferramentas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcessoFerramentas",
                table: "AcessoFerramentas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcessoFerramentas_Colaboradors_ColaboradorId",
                table: "AcessoFerramentas",
                column: "ColaboradorId",
                principalTable: "Colaboradors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AcessoFerramentas_Ferramentas_FerramentaId",
                table: "AcessoFerramentas",
                column: "FerramentaId",
                principalTable: "Ferramentas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcessoFerramentas_Colaboradors_ColaboradorId",
                table: "AcessoFerramentas");

            migrationBuilder.DropForeignKey(
                name: "FK_AcessoFerramentas_Ferramentas_FerramentaId",
                table: "AcessoFerramentas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ferramentas",
                table: "Ferramentas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcessoFerramentas",
                table: "AcessoFerramentas");

            migrationBuilder.RenameTable(
                name: "Ferramentas",
                newName: "Ferramenta");

            migrationBuilder.RenameTable(
                name: "AcessoFerramentas",
                newName: "AcessoFerramenta");

            migrationBuilder.RenameIndex(
                name: "IX_AcessoFerramentas_FerramentaId",
                table: "AcessoFerramenta",
                newName: "IX_AcessoFerramenta_FerramentaId");

            migrationBuilder.RenameIndex(
                name: "IX_AcessoFerramentas_ColaboradorId",
                table: "AcessoFerramenta",
                newName: "IX_AcessoFerramenta_ColaboradorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ferramenta",
                table: "Ferramenta",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcessoFerramenta",
                table: "AcessoFerramenta",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcessoFerramenta_Colaboradors_ColaboradorId",
                table: "AcessoFerramenta",
                column: "ColaboradorId",
                principalTable: "Colaboradors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AcessoFerramenta_Ferramenta_FerramentaId",
                table: "AcessoFerramenta",
                column: "FerramentaId",
                principalTable: "Ferramenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
