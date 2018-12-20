using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class InitialMigrationAfterRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Segmento = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    NomeUsuario = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    SenhaTemporaria = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Documento = table.Column<string>(nullable: true),
                    CPF = table.Column<long>(nullable: false),
                    FotoPath = table.Column<string>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    QtdHorasServico1 = table.Column<int>(nullable: false),
                    QtdHorasServico2 = table.Column<int>(nullable: false),
                    QtdHorasServico3 = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataEntrega = table.Column<DateTime>(nullable: false),
                    EscopoProjeto = table.Column<string>(nullable: true),
                    ForaEscopoProjeto = table.Column<string>(nullable: true),
                    Premissas = table.Column<string>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: true),
                    Status = table.Column<short>(nullable: false),
                    DataPrevista = table.Column<DateTime>(nullable: false),
                    BeneficioEntregue = table.Column<string>(nullable: true),
                    BeneficioResidual = table.Column<string>(nullable: true),
                    ProblemasExecucao = table.Column<string>(nullable: true),
                    Riscos = table.Column<string>(nullable: true),
                    LicoesAprendidas = table.Column<string>(nullable: true),
                    CentroCusto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projetos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colaboradors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    IdPessoa = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: true),
                    Racf = table.Column<string>(nullable: true),
                    EmailCorporativo = table.Column<string>(nullable: true),
                    Funcional = table.Column<int>(nullable: false),
                    NomeMaquina = table.Column<string>(nullable: true),
                    Funcao = table.Column<int>(nullable: false),
                    Perfil = table.Column<int>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaboradors_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    NumeroTelefone = table.Column<string>(nullable: true),
                    TipoTelefone = table.Column<int>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anexos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    IdProjeto = table.Column<int>(nullable: false),
                    ProjetoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anexos_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Changes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    HorasImpacto = table.Column<short>(nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(nullable: false),
                    IdProjeto = table.Column<int>(nullable: false),
                    ProjetoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Changes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Changes_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoPessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    IdProjeto = table.Column<int>(nullable: false),
                    ProjetoId = table.Column<int>(nullable: true),
                    IdPessoa = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoPessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjetoPessoas_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjetoPessoas_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EsforcoProjetos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    IdProjetoPessoa = table.Column<int>(nullable: false),
                    ProjetoPessoaId = table.Column<int>(nullable: true),
                    QtdHorasDia = table.Column<short>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: true),
                    DataFim = table.Column<DateTime>(nullable: true),
                    DataRegistro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EsforcoProjetos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EsforcoProjetos_ProjetoPessoas_ProjetoPessoaId",
                        column: x => x.ProjetoPessoaId,
                        principalTable: "ProjetoPessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoPessoaAtribuicoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    IdProjetoPessoa = table.Column<int>(nullable: false),
                    ProjetoPessoaId = table.Column<int>(nullable: true),
                    Atribuicao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoPessoaAtribuicoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjetoPessoaAtribuicoes_ProjetoPessoas_ProjetoPessoaId",
                        column: x => x.ProjetoPessoaId,
                        principalTable: "ProjetoPessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anexos_ProjetoId",
                table: "Anexos",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Changes_ProjetoId",
                table: "Changes",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradors_PessoaId",
                table: "Colaboradors",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_EsforcoProjetos_ProjetoPessoaId",
                table: "EsforcoProjetos",
                column: "ProjetoPessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_EmpresaId",
                table: "Pessoas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoaAtribuicoes_ProjetoPessoaId",
                table: "ProjetoPessoaAtribuicoes",
                column: "ProjetoPessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_PessoaId",
                table: "ProjetoPessoas",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_ProjetoId",
                table: "ProjetoPessoas",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_EmpresaId",
                table: "Projetos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones",
                column: "PessoaId");
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
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "ProjetoPessoas");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Projetos");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
