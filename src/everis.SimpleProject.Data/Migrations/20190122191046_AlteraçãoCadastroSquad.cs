using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AlteraçãoCadastroSquad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Squads_Pessoas_PessoaId",
                table: "Squads");

            migrationBuilder.DropForeignKey(
                name: "FK_Squads_Telefones_TelefoneId",
                table: "Squads");

            migrationBuilder.DropIndex(
                name: "IX_Squads_PessoaId",
                table: "Squads");

            migrationBuilder.DropIndex(
                name: "IX_Squads_TelefoneId",
                table: "Squads");

            migrationBuilder.DropColumn(
                name: "GerenteComunidade",
                table: "Squads");

            migrationBuilder.DropColumn(
                name: "GerenteResponsavel",
                table: "Squads");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Squads");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "Squads");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GerenteComunidade",
                table: "Squads",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GerenteResponsavel",
                table: "Squads",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Squads",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelefoneId",
                table: "Squads",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Squads_PessoaId",
                table: "Squads",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_TelefoneId",
                table: "Squads",
                column: "TelefoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Squads_Pessoas_PessoaId",
                table: "Squads",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Squads_Telefones_TelefoneId",
                table: "Squads",
                column: "TelefoneId",
                principalTable: "Telefones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
