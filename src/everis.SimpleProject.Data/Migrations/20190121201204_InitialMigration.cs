using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace everis.SimpleProject.Data.EF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreasContratantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasContratantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comunidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comunidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiretoriasContratantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiretoriasContratantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    Segmento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ferramentas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferramentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PoloAcessos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoloAcessos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjetoPessoaAtribuicoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Atribuicao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoPessoaAtribuicoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Siglas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siglas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Codigo = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Superintendencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superintendencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoServicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoServicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposFases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposFases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTelefones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTelefones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    NomeUsuario = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(maxLength: 255, nullable: false),
                    SenhaTemporaria = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colaboradors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    FuncaoId = table.Column<int>(nullable: false),
                    PoloAcessoId = table.Column<int>(nullable: false),
                    AreaContratanteId = table.Column<int>(nullable: false),
                    TipoServicoId = table.Column<int>(nullable: false),
                    Racf = table.Column<string>(nullable: true),
                    EmailCorporativo = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    DataAdmissao = table.Column<DateTime>(nullable: false),
                    DataDemissao = table.Column<DateTime>(nullable: false),
                    NomeMaquina = table.Column<string>(nullable: true),
                    Scf = table.Column<bool>(nullable: false),
                    Clt = table.Column<bool>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false),
                    Senha = table.Column<string>(nullable: true),
                    OcupacaoFisicaPoloAdm = table.Column<bool>(nullable: false),
                    ContratoSAP = table.Column<string>(nullable: true),
                    ExclusivoCliente = table.Column<bool>(nullable: false),
                    TipoContratacao = table.Column<string>(nullable: true),
                    GestorTecnicoCliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaboradors_AreasContratantes_AreaContratanteId",
                        column: x => x.AreaContratanteId,
                        principalTable: "AreasContratantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Colaboradors_Funcoes_FuncaoId",
                        column: x => x.FuncaoId,
                        principalTable: "Funcoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Colaboradors_PoloAcessos_PoloAcessoId",
                        column: x => x.PoloAcessoId,
                        principalTable: "PoloAcessos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Colaboradors_TipoServicos_TipoServicoId",
                        column: x => x.TipoServicoId,
                        principalTable: "TipoServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AcessoFerramentas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    FerramentaId = table.Column<int>(nullable: false),
                    ColaboradorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcessoFerramentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcessoFerramentas_Colaboradors_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaboradors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcessoFerramentas_Ferramentas_FerramentaId",
                        column: x => x.FerramentaId,
                        principalTable: "Ferramentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcessoSiglas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    SiglaId = table.Column<int>(nullable: false),
                    ColaboradorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcessoSiglas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcessoSiglas_Colaboradors_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaboradors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcessoSiglas_Siglas_SiglaId",
                        column: x => x.SiglaId,
                        principalTable: "Siglas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    DiretoriaId = table.Column<int>(nullable: true),
                    ColaboradorId = table.Column<int>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    TipoId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: false),
                    Documento = table.Column<string>(nullable: true),
                    CPF = table.Column<long>(nullable: false),
                    Rg = table.Column<long>(nullable: false),
                    OrgaoEmissor = table.Column<string>(nullable: true),
                    UFRg = table.Column<string>(nullable: true),
                    FotoPath = table.Column<string>(nullable: true),
                    Funcional = table.Column<int>(nullable: false),
                    GestorTecnico = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Colaboradors_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaboradors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoas_DiretoriasContratantes_DiretoriaId",
                        column: x => x.DiretoriaId,
                        principalTable: "DiretoriasContratantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pessoas_TipoPessoas_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TipoPessoas",
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
                    NumeroTelefone = table.Column<string>(nullable: false),
                    TipoId = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Telefones_TipoTelefones_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TipoTelefones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    IdSquad = table.Column<int>(nullable: false),
                    GerenteResponsavel = table.Column<string>(nullable: false),
                    GerenteComunidade = table.Column<string>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false),
                    ComunidadeId = table.Column<int>(nullable: false),
                    TelefoneId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Squads_Comunidades_ComunidadeId",
                        column: x => x.ComunidadeId,
                        principalTable: "Comunidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Squads_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Squads_Telefones_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "Telefones",
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
                    CodigoProjeto = table.Column<string>(nullable: true),
                    QtdHorasServico1 = table.Column<int>(nullable: false),
                    QtdHorasServico2 = table.Column<int>(nullable: false),
                    QtdHorasServico3 = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataEntrega = table.Column<DateTime>(nullable: false),
                    EscopoProjeto = table.Column<string>(nullable: false),
                    ForaEscopoProjeto = table.Column<string>(nullable: true),
                    Premissas = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    DataPrevista = table.Column<DateTime>(nullable: false),
                    BeneficioEntregue = table.Column<string>(nullable: true),
                    BeneficioResidual = table.Column<string>(nullable: true),
                    ProblemasExecucao = table.Column<string>(nullable: true),
                    Riscos = table.Column<string>(nullable: true),
                    LicoesAprendidas = table.Column<string>(nullable: true),
                    Ext = table.Column<string>(nullable: false),
                    DataRecebida = table.Column<DateTime>(nullable: false),
                    Tecnologia = table.Column<string>(nullable: false),
                    Sigla = table.Column<string>(nullable: false),
                    RespOutsourcing = table.Column<string>(nullable: false),
                    RespTI = table.Column<string>(nullable: false),
                    RespGerente = table.Column<string>(nullable: false),
                    DiretoriaId = table.Column<int>(nullable: false),
                    Tamanho = table.Column<string>(nullable: false),
                    TipoDemanda = table.Column<string>(nullable: false),
                    Tarifa = table.Column<string>(nullable: false),
                    SuperintendenciaId = table.Column<string>(nullable: true),
                    Superintendencia = table.Column<string>(nullable: false),
                    SquadId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projetos_DiretoriasContratantes_DiretoriaId",
                        column: x => x.DiretoriaId,
                        principalTable: "DiretoriasContratantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projetos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projetos_Squads_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projetos_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SquadPessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    SquadId = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadPessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SquadPessoas_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SquadPessoas_Squads_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squads",
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
                    Descricao = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    ProjetoId = table.Column<int>(nullable: false)
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
                    Descricao = table.Column<string>(nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(nullable: false),
                    ProjetoId = table.Column<int>(nullable: false),
                    QtdHorasServico1 = table.Column<int>(nullable: false),
                    QtdHorasServico2 = table.Column<int>(nullable: false),
                    QtdHorasServico3 = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Changes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Changes_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Changes_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    ProjetoId = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false),
                    TipoFaseId = table.Column<int>(nullable: false),
                    QtdHorasDia = table.Column<short>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    CodigoFase = table.Column<int>(nullable: false),
                    DataRegistro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fases_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fases_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fases_TiposFases_TipoFaseId",
                        column: x => x.TipoFaseId,
                        principalTable: "TiposFases",
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
                    ProjetoId = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false),
                    AtribuicaoId = table.Column<int>(nullable: false),
                    Responsavel = table.Column<bool>(nullable: false),
                    ProjetoId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoPessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjetoPessoas_ProjetoPessoaAtribuicoes_AtribuicaoId",
                        column: x => x.AtribuicaoId,
                        principalTable: "ProjetoPessoaAtribuicoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_ProjetoPessoas_Projetos_ProjetoId1",
                        column: x => x.ProjetoId1,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcessoFerramentas_ColaboradorId",
                table: "AcessoFerramentas",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_AcessoFerramentas_FerramentaId",
                table: "AcessoFerramentas",
                column: "FerramentaId");

            migrationBuilder.CreateIndex(
                name: "IX_AcessoSiglas_ColaboradorId",
                table: "AcessoSiglas",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_AcessoSiglas_SiglaId",
                table: "AcessoSiglas",
                column: "SiglaId");

            migrationBuilder.CreateIndex(
                name: "IX_Anexos_ProjetoId",
                table: "Anexos",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Changes_PessoaId",
                table: "Changes",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Changes_ProjetoId",
                table: "Changes",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradors_AreaContratanteId",
                table: "Colaboradors",
                column: "AreaContratanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradors_FuncaoId",
                table: "Colaboradors",
                column: "FuncaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradors_PoloAcessoId",
                table: "Colaboradors",
                column: "PoloAcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradors_TipoServicoId",
                table: "Colaboradors",
                column: "TipoServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fases_PessoaId",
                table: "Fases",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fases_ProjetoId",
                table: "Fases",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fases_TipoFaseId",
                table: "Fases",
                column: "TipoFaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_ColaboradorId",
                table: "Pessoas",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_DiretoriaId",
                table: "Pessoas",
                column: "DiretoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_EmpresaId",
                table: "Pessoas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_TipoId",
                table: "Pessoas",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_AtribuicaoId",
                table: "ProjetoPessoas",
                column: "AtribuicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_PessoaId",
                table: "ProjetoPessoas",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_ProjetoId",
                table: "ProjetoPessoas",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjetoPessoas_ProjetoId1",
                table: "ProjetoPessoas",
                column: "ProjetoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_DiretoriaId",
                table: "Projetos",
                column: "DiretoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_EmpresaId",
                table: "Projetos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_SquadId",
                table: "Projetos",
                column: "SquadId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_StatusId",
                table: "Projetos",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadPessoas_PessoaId",
                table: "SquadPessoas",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadPessoas_SquadId",
                table: "SquadPessoas",
                column: "SquadId");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_ComunidadeId",
                table: "Squads",
                column: "ComunidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_PessoaId",
                table: "Squads",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Squads_TelefoneId",
                table: "Squads",
                column: "TelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_TipoId",
                table: "Telefones",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcessoFerramentas");

            migrationBuilder.DropTable(
                name: "AcessoSiglas");

            migrationBuilder.DropTable(
                name: "Anexos");

            migrationBuilder.DropTable(
                name: "Changes");

            migrationBuilder.DropTable(
                name: "Fases");

            migrationBuilder.DropTable(
                name: "Perfis");

            migrationBuilder.DropTable(
                name: "ProjetoPessoas");

            migrationBuilder.DropTable(
                name: "SquadPessoas");

            migrationBuilder.DropTable(
                name: "Superintendencia");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Ferramentas");

            migrationBuilder.DropTable(
                name: "Siglas");

            migrationBuilder.DropTable(
                name: "TiposFases");

            migrationBuilder.DropTable(
                name: "ProjetoPessoaAtribuicoes");

            migrationBuilder.DropTable(
                name: "Projetos");

            migrationBuilder.DropTable(
                name: "Squads");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Comunidades");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "TipoTelefones");

            migrationBuilder.DropTable(
                name: "Colaboradors");

            migrationBuilder.DropTable(
                name: "DiretoriasContratantes");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "TipoPessoas");

            migrationBuilder.DropTable(
                name: "AreasContratantes");

            migrationBuilder.DropTable(
                name: "Funcoes");

            migrationBuilder.DropTable(
                name: "PoloAcessos");

            migrationBuilder.DropTable(
                name: "TipoServicos");
        }
    }
}
