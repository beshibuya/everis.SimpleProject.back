using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class alteracoesProjeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "Superintendencia",
                table: "Projetos");

            migrationBuilder.RenameColumn(
                name: "Tecnologia",
                table: "Projetos",
                newName: "StatusProposta");

            migrationBuilder.AlterColumn<int>(
                name: "TecnologiaId",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SuperintendenciaId",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RespTI",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RespOutsourcing",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RespGerente",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataProposta",
                table: "Projetos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SiglaId",
                table: "Projetos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_SiglaId",
                table: "Projetos",
                column: "SiglaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_SuperintendenciaId",
                table: "Projetos",
                column: "SuperintendenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_TecnologiaId",
                table: "Projetos",
                column: "TecnologiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Siglas_SiglaId",
                table: "Projetos",
                column: "SiglaId",
                principalTable: "Siglas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Superintendencia_SuperintendenciaId",
                table: "Projetos",
                column: "SuperintendenciaId",
                principalTable: "Superintendencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Tecnologia_TecnologiaId",
                table: "Projetos",
                column: "TecnologiaId",
                principalTable: "Tecnologia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Siglas_SiglaId",
                table: "Projetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Superintendencia_SuperintendenciaId",
                table: "Projetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Tecnologia_TecnologiaId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_SiglaId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_SuperintendenciaId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_TecnologiaId",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "DataProposta",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "SiglaId",
                table: "Projetos");

            migrationBuilder.RenameColumn(
                name: "StatusProposta",
                table: "Projetos",
                newName: "Tecnologia");

            migrationBuilder.AlterColumn<string>(
                name: "TecnologiaId",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "SuperintendenciaId",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "RespTI",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RespOutsourcing",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RespGerente",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "Projetos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Superintendencia",
                table: "Projetos",
                nullable: false,
                defaultValue: "");
        }
    }
}
