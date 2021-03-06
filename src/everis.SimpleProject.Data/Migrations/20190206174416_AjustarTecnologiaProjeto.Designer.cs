﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using everis.SimpleProject.Data.EF;

namespace everis.SimpleProject.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190206174416_AjustarTecnologiaProjeto")]
    partial class AjustarTecnologiaProjeto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.AcessoFerramenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("ColaboradorId");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<int>("FerramentaId");

                    b.HasKey("Id");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("FerramentaId");

                    b.ToTable("AcessoFerramentas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.AcessoSigla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("ColaboradorId");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<int>("SiglaId");

                    b.HasKey("Id");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("SiglaId");

                    b.ToTable("AcessoSiglas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Anexo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<int>("ProjetoId");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Anexos");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.AreaContratante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("AreasContratantes");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AreaContratanteId");

                    b.Property<bool>("Ativo");

                    b.Property<bool>("Clt");

                    b.Property<string>("ContratoSAP");

                    b.Property<DateTime>("DataAdmissao");

                    b.Property<DateTime?>("DataDemissao");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<bool>("Disponivel");

                    b.Property<string>("EmailCorporativo")
                        .IsRequired();

                    b.Property<bool>("ExclusivoCliente");

                    b.Property<int>("FuncaoId");

                    b.Property<string>("GestorTecnicoCliente");

                    b.Property<string>("NomeMaquina");

                    b.Property<bool>("OcupacaoFisicaPoloAdm");

                    b.Property<int>("PessoaId");

                    b.Property<int>("PoloAcessoId");

                    b.Property<string>("Racf");

                    b.Property<bool>("Scf");

                    b.Property<string>("Senha");

                    b.Property<string>("TipoContratacao");

                    b.Property<int>("TipoServicoId");

                    b.HasKey("Id");

                    b.HasIndex("AreaContratanteId");

                    b.HasIndex("FuncaoId");

                    b.HasIndex("PessoaId");

                    b.HasIndex("PoloAcessoId");

                    b.HasIndex("TipoServicoId");

                    b.ToTable("Colaboradors");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Comunidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Comunidades");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.DiretoriaContratante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("DiretoriasContratantes");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Segmento");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Fase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("CodigoFase");

                    b.Property<DateTime?>("DataFim");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<DateTime?>("DataInicio")
                        .IsRequired();

                    b.Property<DateTime>("DataRegistro");

                    b.Property<string>("Observacao");

                    b.Property<int>("PessoaId");

                    b.Property<int>("ProjetoId");

                    b.Property<short>("QtdHorasDia");

                    b.Property<int>("TipoFaseId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("ProjetoId");

                    b.HasIndex("TipoFaseId");

                    b.ToTable("Fases");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Ferramenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Ferramentas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Funcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Funcoes");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Perfis");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<long>("CPF");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<int?>("DiretoriaId");

                    b.Property<string>("Documento");

                    b.Property<string>("Email");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("FotoPath");

                    b.Property<int>("Funcional");

                    b.Property<bool>("GestorTecnico");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("OrgaoEmissor");

                    b.Property<long>("Rg");

                    b.Property<string>("Sexo")
                        .IsRequired();

                    b.Property<int>("TipoId");

                    b.Property<string>("UFRg");

                    b.HasKey("Id");

                    b.HasIndex("DiretoriaId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("TipoId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.PoloAcesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("PoloAcessos");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("BeneficioEntregue");

                    b.Property<string>("BeneficioResidual");

                    b.Property<string>("CodigoProjeto")
                        .IsRequired();

                    b.Property<DateTime?>("DataFinal");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<DateTime?>("DataInicio");

                    b.Property<DateTime?>("DataProposta");

                    b.Property<DateTime>("DataRecebida");

                    b.Property<int>("DiretoriaId");

                    b.Property<int>("Duracao");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("EscopoProjeto");

                    b.Property<string>("Ext");

                    b.Property<string>("ForaEscopoProjeto");

                    b.Property<string>("LicoesAprendidas");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Premissas");

                    b.Property<string>("ProblemasExecucao");

                    b.Property<int>("QtdHorasServico1");

                    b.Property<int>("QtdHorasServico2");

                    b.Property<int>("QtdHorasServico3");

                    b.Property<string>("Riscos");

                    b.Property<int>("SiglaId");

                    b.Property<int?>("SquadId");

                    b.Property<int?>("StatusId")
                        .IsRequired();

                    b.Property<string>("StatusProposta");

                    b.Property<int>("SuperintendenciaId");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<decimal>("Tarifa");

                    b.Property<string>("TipoDemanda")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DiretoriaId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("SiglaId");

                    b.HasIndex("SquadId");

                    b.HasIndex("StatusId");

                    b.HasIndex("SuperintendenciaId");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoPessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("AtribuicaoId");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<int>("PessoaId");

                    b.Property<int>("ProjetoId");

                    b.Property<bool>("Responsavel");

                    b.HasKey("Id");

                    b.HasIndex("AtribuicaoId");

                    b.HasIndex("PessoaId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("ProjetoPessoas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoPessoaAtribuicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Atribuicao")
                        .IsRequired();

                    b.Property<DateTime?>("DataInativacao");

                    b.HasKey("Id");

                    b.ToTable("ProjetoPessoaAtribuicoes");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoSquad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<int>("ProjetoId");

                    b.Property<int?>("SquadId");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.HasIndex("SquadId");

                    b.ToTable("ProjetoSquads");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoTecnologia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<int>("ProjetoId");

                    b.Property<int>("TecnologiaId");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.HasIndex("TecnologiaId");

                    b.ToTable("ProjetoTecnologia");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Sigla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Siglas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.SolicitacaoMudanca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataHoraCadastro");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int>("PessoaId");

                    b.Property<int>("ProjetoId");

                    b.Property<int>("QtdHorasServico1");

                    b.Property<int>("QtdHorasServico2");

                    b.Property<int>("QtdHorasServico3");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Changes");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Squad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int?>("Codigo");

                    b.Property<int>("ComunidadeId");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ComunidadeId");

                    b.ToTable("Squads");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.SquadPessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<int>("PessoaId");

                    b.Property<int>("SquadId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("SquadId");

                    b.ToTable("SquadPessoas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Codigo")
                        .IsRequired();

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Superintendencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Superintendencia");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Tecnologia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Tecnologia");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("NumeroTelefone")
                        .IsRequired();

                    b.Property<int>("PessoaId");

                    b.Property<int>("TipoId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("TipoId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.TipoFase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TiposFases");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.TipoPessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoPessoas");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.TipoServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoServicos");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.TipoTelefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataInativacao");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoTelefones");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.AcessoFerramenta", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Ferramenta", "Ferramenta")
                        .WithMany()
                        .HasForeignKey("FerramentaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.AcessoSigla", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Sigla", "Sigla")
                        .WithMany()
                        .HasForeignKey("SiglaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Anexo", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Colaborador", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.AreaContratante", "AreaContratante")
                        .WithMany()
                        .HasForeignKey("AreaContratanteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Funcao", "Funcao")
                        .WithMany()
                        .HasForeignKey("FuncaoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.PoloAcesso", "PoloAcesso")
                        .WithMany()
                        .HasForeignKey("PoloAcessoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.TipoServico", "TipoServico")
                        .WithMany()
                        .HasForeignKey("TipoServicoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Fase", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.TipoFase", "TipoFase")
                        .WithMany()
                        .HasForeignKey("TipoFaseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Pessoa", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.DiretoriaContratante", "Diretoria")
                        .WithMany()
                        .HasForeignKey("DiretoriaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("everis.SimpleProject.Domain.Models.TipoPessoa", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Projeto", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.DiretoriaContratante", "Diretoria")
                        .WithMany()
                        .HasForeignKey("DiretoriaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Sigla", "Sigla")
                        .WithMany()
                        .HasForeignKey("SiglaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("everis.SimpleProject.Domain.Models.Squad", "Squad")
                        .WithMany()
                        .HasForeignKey("SquadId");

                    b.HasOne("everis.SimpleProject.Domain.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Superintendencia", "Superintendencia")
                        .WithMany()
                        .HasForeignKey("SuperintendenciaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoPessoa", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.ProjetoPessoaAtribuicao", "Atribuicao")
                        .WithMany()
                        .HasForeignKey("AtribuicaoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoSquad", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("everis.SimpleProject.Domain.Models.Squad", "Squad")
                        .WithMany()
                        .HasForeignKey("SquadId");
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.ProjetoTecnologia", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Tecnologia", "Tecnologia")
                        .WithMany()
                        .HasForeignKey("TecnologiaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.SolicitacaoMudanca", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Squad", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Comunidade", "Comunidade")
                        .WithMany()
                        .HasForeignKey("ComunidadeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.SquadPessoa", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.Squad", "Squad")
                        .WithMany()
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("everis.SimpleProject.Domain.Models.Telefone", b =>
                {
                    b.HasOne("everis.SimpleProject.Domain.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("everis.SimpleProject.Domain.Models.TipoTelefone", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
