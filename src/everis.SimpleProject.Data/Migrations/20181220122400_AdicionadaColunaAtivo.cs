using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class AdicionadaColunaAtivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Usuarios",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Changes",
                columns: table => new
                {
                    IdChange = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    HorasImpacto = table.Column<short>(nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Changes", x => x.IdChange);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Segmento = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoPessoaAtribuicoes",
                columns: table => new
                {
                    IdProjetoPessoa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Atribuicao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoPessoaAtribuicoes", x => x.IdProjetoPessoa);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Documento = table.Column<string>(nullable: true),
                    CPF = table.Column<long>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    FotoPath = table.Column<string>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.IdPessoa);
                    table.ForeignKey(
                        name: "FK_Pessoas_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    IdProjeto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    QtdHorasServico1 = table.Column<int>(nullable: false),
                    QtdHorasServico2 = table.Column<int>(nullable: false),
                    QtdHorasServico3 = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataEntrega = table.Column<DateTime>(nullable: false),
                    EscopoProjeto = table.Column<string>(nullable: false),
                    ForaEscopoProjeto = table.Column<string>(nullable: true),
                    Premissas = table.Column<string>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false),
                    Status = table.Column<short>(nullable: false),
                    DataPrevista = table.Column<DateTime>(nullable: false),
                    BeneficioEntregue = table.Column<string>(nullable: true),
                    BeneficioResidual = table.Column<string>(nullable: true),
                    ProblemasExecucao = table.Column<string>(nullable: true),
                    Riscos = table.Column<string>(nullable: true),
                    LicoesAprendidas = table.Column<string>(nullable: true),
                    CentroCusto = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.IdProjeto);
                    table.ForeignKey(
                        name: "FK_Projetos_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colaboradors",
                columns: table => new
                {
                    IdColaborador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false),
                    Racf = table.Column<string>(nullable: true),
                    EmailCorp = table.Column<string>(nullable: false),
                    Funcional = table.Column<int>(nullable: false),
                    NomeMaquina = table.Column<string>(nullable: true),
                    Funcao = table.Column<int>(nullable: false),
                    Perfil = table.Column<int>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradors", x => x.IdColaborador);
                    table.ForeignKey(
                        name: "FK_Colaboradors_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    IdTelefone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    NumeroTelefone = table.Column<string>(nullable: false),
                    Tipo = table.Column<short>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.IdTelefone);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anexos",
                columns: table => new
                {
                    IdAnexo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    IdProjeto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexos", x => x.IdAnexo);
                    table.ForeignKey(
                        name: "FK_Anexos_Projetos_IdProjeto",
                        column: x => x.IdProjeto,
                        principalTable: "Projetos",
                        principalColumn: "IdProjeto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoPessoas",
                columns: table => new
                {
                    IdProjetoPessoa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    IdProjeto = table.Column<int>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoPessoas", x => x.IdProjetoPessoa);
                    table.ForeignKey(
                        name: "FK_ProjetoPessoas_Pessoas_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjetoPessoas_Projetos_IdProjeto",
                        column: x => x.IdProjeto,
                        principalTable: "Projetos",
                        principalColumn: "IdProjeto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EsforcoProjetos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    IdProjetoPessoa = table.Column<int>(nullable: false),
                    ProjetoPessoaIdProjetoPessoa = table.Column<int>(nullable: false),
                    QtdHorasDia = table.Column<short>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    DataRegistro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EsforcoProjetos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EsforcoProjetos_ProjetoPessoas_ProjetoPessoaIdProjetoPessoa",
                        column: x => x.ProjetoPessoaIdProjetoPessoa,
                        principalTable: "ProjetoPessoas",
                        principalColumn: "IdProjetoPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anexos_IdProjeto",
                table: "Anexos",
                column: "IdProjeto");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradors_IdPessoa",
                table: "Colaboradors",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_EsforcoProjetos_ProjetoPessoaIdProjetoPessoa",
                table: "EsforcoProjetos",
                column: "ProjetoPessoaIdProjetoPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_IdEmpresa",
                table: "Pessoas",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_IdPessoa",
                table: "ProjetoPessoas",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_IdProjeto",
                table: "ProjetoPessoas",
                column: "IdProjeto");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_IdEmpresa",
                table: "Projetos",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_IdPessoa",
                table: "Telefones",
                column: "IdPessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anexos");

            migrationBuilder.DropTable(
                name: "Changes");

            migrationBuilder.DropTable(
                name: "Colaboradors");

            migrationBuilder.DropTable(
                name: "EsforcoProjetos");

            migrationBuilder.DropTable(
                name: "ProjetoPessoaAtribuicoes");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "ProjetoPessoas");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Projetos");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Usuarios");
        }
    }
}
