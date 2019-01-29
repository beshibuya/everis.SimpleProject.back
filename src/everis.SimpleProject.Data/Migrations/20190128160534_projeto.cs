using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class projeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RespGerente",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "RespOutsourcing",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "RespTI",
                table: "Projetos");

            migrationBuilder.RenameColumn(
                name: "DataPrevista",
                table: "Projetos",
                newName: "DataFinal");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tarifa",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "StatusProposta",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ext",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EscopoProjeto",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CodigoProjeto",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Duracao",
                table: "Projetos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duracao",
                table: "Projetos");

            migrationBuilder.RenameColumn(
                name: "DataFinal",
                table: "Projetos",
                newName: "DataPrevista");

            migrationBuilder.AlterColumn<string>(
                name: "Tarifa",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "StatusProposta",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Ext",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EscopoProjeto",
                table: "Projetos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoProjeto",
                table: "Projetos",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "RespGerente",
                table: "Projetos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RespOutsourcing",
                table: "Projetos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RespTI",
                table: "Projetos",
                nullable: true);
        }
    }
}
