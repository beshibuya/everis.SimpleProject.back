using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Data.EF.Context
{
    public static class DbContextExtension
    {
        public static bool AllMigrationsApplied(this AppDbContext context)
        {
            var applied = context.GetService<IHistoryRepository>().
                GetAppliedMigrations()
                .Select(s => s.MigrationId);
            var total = context.GetService<IMigrationsAssembly>().
                Migrations.Select(m => m.Key);
            return !total.Except(applied).Any();
        }

        public static void InitialSeed(this AppDbContext context)
        {


            #region Inserts TipoPessoas

            if (!context.TipoPessoas.Any())
            {
                context.Add(new TipoPessoa
                {
                    Descricao = "Colaborador"
                });

                context.Add(new TipoPessoa
                {
                    Descricao = "Cliente"
                });

                context.Add(new TipoPessoa
                {
                    Descricao = "Terceiro"
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts TipoTelefones
            if (!context.TipoTelefones.Any())
            {
                context.Add(new TipoTelefone
                {
                    Descricao = "Celular"
                });

                context.Add(new TipoTelefone
                {
                    Descricao = "Fixo"
                });

                context.Add(new TipoTelefone
                {
                    Descricao = "Ramal"
                });

                context.SaveChanges();

            }
            #endregion

            #region Inserts Funcoes
            if (!context.Funcoes.Any())
            {
                context.Add(new Funcao
                {
                    Descricao = "SA"
                });

                context.Add(new Funcao
                {
                    Descricao = "SN"
                });

                context.Add(new Funcao
                {
                    Descricao = "STL"
                });

                context.Add(new Funcao
                {
                    Descricao = "SPL"
                });

                context.Add(new Funcao
                {
                    Descricao = "SK"
                });

                context.Add(new Funcao
                {
                    Descricao = "SKL"
                });

                context.Add(new Funcao
                {
                    Descricao = "Manager"
                });

                context.SaveChanges();
            }
            #endregion

            #region Inserts PoloAcesso
            if (!context.PoloAcessos.Any())
            {
                context.Add(new PoloAcesso
                {
                    Descricao = "Centro Tecnologico (CTO)"
                });

                context.Add(new PoloAcesso
                {
                    Descricao = "Centro Empresarial (CEIC)"
                });

                context.Add(new PoloAcesso
                {
                    Descricao = "ACESSO REMOTO"
                });

                context.SaveChanges();
            }
            #endregion

            #region Inserts AreaContratante

            if (!context.AreasContratantes.Any())
            {
                context.Add(new AreaContratante
                {
                    Descricao = "SSRF"
                });

                context.Add(new AreaContratante
                {
                    Descricao = "SSFO"
                });

                context.Add(new AreaContratante
                {
                    Descricao = "SSPOA"
                });

                context.Add(new AreaContratante
                {
                    Descricao = "STIM"
                });

                context.Add(new AreaContratante
                {
                    Descricao = "SQT"
                });

                context.Add(new AreaContratante
                {
                    Descricao = "STIM"
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts DiretoriaContratante

            if (!context.DiretoriasContratantes.Any())
            {
                context.Add(new DiretoriaContratante
                {
                    Descricao = "DD"
                });

                context.Add(new DiretoriaContratante
                {
                    Descricao = "DESB"
                });

                context.Add(new DiretoriaContratante
                {
                    Descricao = "DCQPTI"
                });

                context.Add(new DiretoriaContratante
                {
                    Descricao = "DDS"
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts TipoServico

            if (!context.TipoServicos.Any())
            {
                context.Add(new TipoServico
                {
                    Descricao = "POOL"
                });

                context.Add(new TipoServico
                {
                    Descricao = "RFP(Consultoria)"
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts Empresa

            if (!context.Empresas.Any())
            {
                context.Add(new Empresa
                {
                    Nome = "Everis",
                    Segmento = TipoSegmento.Banking
                });
                context.Add(new Empresa
                {
                    Nome = "Itaú",
                    Segmento = TipoSegmento.Banking
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts Superintendencia

            if (!context.Superintendencia.Any())
            {
                context.Add(new Superintendencia
                {
                    Descricao = "SDACS"
                });

                context.Add(new Superintendencia
                {
                    Descricao = "SDCD"
                });
                context.Add(new Superintendencia
                {
                    Descricao = "SDCT"
                });
                context.Add(new Superintendencia
                {
                    Descricao = "SDPSB"
                });
                context.Add(new Superintendencia
                {
                    Descricao = "SPDC"
                });
                context.Add(new Superintendencia
                {
                    Descricao = "SQT"
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts Pessoa


            if (!context.Pessoas.Any())
            {
                context.Add(new Pessoa
                {
                    Nome = "Administrador",
                    EmpresaId = 1,
                    TipoId = 3,
                    Email = "admin@admin.com",
                    Funcional = 423947876,
                    Sexo = "Masculino",
                    DiretoriaId = 1,
                    GestorTecnico = true
                });

                context.SaveChanges();
            }
            #endregion

            #region Inserts Colaborador

            if (!context.Colaboradors.Any())
            {
                context.Add(new Colaborador
                {
                    Disponivel = false,
                    EmailCorporativo = "admin@admin.com",
                    FuncaoId = 1,
                    AreaContratanteId = 2,
                    PoloAcessoId = 1,
                    TipoServicoId = 1,
                    Senha = "admin",
                    PessoaId = 1,
                    DataNascimento = new DateTime(),
                    DataAdmissao = new DateTime()
                });

                context.SaveChanges();
            }
            #endregion

            #region Inserts Status

            if (!context.Status.Any())
            {
                context.Add(new Status
                {
                    Codigo = "DES",
                    Descricao = "Em desenvolvimento"
                });

                context.Add(new Status
                {
                    Codigo = "APR",
                    Descricao = "Aguardando aprovação"
                });

                context.Add(new Status
                {
                    Codigo = "CON",
                    Descricao = "Concluído"
                });

                context.Add(new Status
                {
                    Codigo = "ENT",
                    Descricao = "Entregue"
                });

                context.Add(new Status
                {
                    Codigo = "AAB",
                    Descricao = "Aguardando abertura"
                });

                context.Add(new Status
                {
                    Codigo = "CAN",
                    Descricao = "Cancelado"
                });

                context.Add(new Status
                {
                    Codigo = "PRO",
                    Descricao = "Proposta"
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts Tecnologia

            if (!context.Tecnologia.Any())
            {
                context.Add(new Tecnologia
                {
                    Nome = ".Net"
                });
                context.Add(new Tecnologia
                {
                    Nome = "Java"
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts Sigla
            if (!context.Siglas.Any())
            {

                context.AddRange(
                    new List<Sigla>
                    {
                        new Sigla{Descricao="BN2"},
                        new Sigla{Descricao="EB6"},
                        new Sigla{Descricao="EB3"},
                        new Sigla{Descricao="COMP_OPEN"},
                        new Sigla{Descricao="VQ1"},
                        new Sigla{Descricao="SI2"},
                        new Sigla{Descricao="BX6"},
                        new Sigla{Descricao="T3"},
                        new Sigla{Descricao="EB5"},
                        new Sigla{Descricao="EA9"},
                        new Sigla{Descricao="JIRA"},
                        new Sigla{Descricao="AA4"},
                        new Sigla{Descricao="GIT"},
                        new Sigla{Descricao="JENKINS"},
                        new Sigla{Descricao="NF2"},
                        new Sigla{Descricao="TB9"}
                    });
                context.SaveChanges();
            }
            #endregion

            #region Inserts Ferramentas

            if (!context.Ferramentas.Any())
            {
                context.AddRange(
                    new List<Ferramenta>
                    {
                    new Ferramenta {
                        Descricao = "Visual Studio"
                    },
                    new Ferramenta
                    {
                        Descricao = "RTC"
                    },
                        new Ferramenta
                    {
                        Descricao = "Angular"
                    },
                        new Ferramenta
                    {
                        Descricao = "GIT"
                    },
                        new Ferramenta
                    {
                        Descricao = "Confluence"
                    },
                        new Ferramenta
                    {
                        Descricao = "Jira"
                    }
                    });
                context.SaveChanges();
            }
            #endregion

            #region Inserts Tipo Fase
            if (!context.TiposFases.Any())
            {

                context.Add(new TipoFase
                {
                    Nome = "Idle"
                });

                context.Add(new TipoFase
                {
                    Nome = "Overhead"
                });

                context.Add(new TipoFase
                {
                    Nome = "Trabalhado"
                });
            }
            #endregion

            #region Inserts Atribuição
            if (!context.ProjetoPessoaAtribuicoes.Any())
            {

                context.Add(new ProjetoPessoaAtribuicao
                {
                    Atribuicao = "Desenvolvedor"
                });
                context.Add(new ProjetoPessoaAtribuicao
                {
                    Atribuicao = "Tester"
                });
                context.Add(new ProjetoPessoaAtribuicao
                {
                    Atribuicao = "Gerente"
                });
                context.Add(new ProjetoPessoaAtribuicao
                {
                    Atribuicao = "Líder"
                });
                context.Add(new ProjetoPessoaAtribuicao
                {
                    Atribuicao = "Analista responsável de TI - técnico"
                });
                context.Add(new ProjetoPessoaAtribuicao
                {
                    Atribuicao = "Analista responsável Outsourcing"
                });
                context.Add(new ProjetoPessoaAtribuicao
                {
                    Atribuicao = "Gerente responsável"
                });
            }
            #endregion

            #region Inserts Tipo Demanda
            if (!context.TipoDemandas.Any())
            {
                context.TipoDemandas.AddRange(
                    new List<TipoDemanda>
                    {
                        new TipoDemanda{Nome="Commodities"},
                        new TipoDemanda{Nome="Especialista"}
                    });
            }
            #endregion Inserts Tipo Demanda

            #region Exts

            if (!context.Exts.Any())
            {
                context.Exts.AddRange(
                    new List<Exts>
                    {
                        new Exts{Nome="EXT-011198-00079",Descricao = "EXT-011198-00079"},
                        new Exts{Nome="EXT-011198-00083",Descricao = "EXT-011198-00083"},
                        new Exts{Nome="EXT-011198-00100",Descricao = "EXT-011198-00100"},
                        new Exts{Nome="EXT-011198-00101",Descricao = "EXT-011198-00101"},
                        new Exts{Nome="EXT-011198-00104",Descricao = "EXT-011198-00104"},
                        new Exts{Nome="EXT-011198-00105",Descricao = "EXT-011198-00105"},
                        new Exts{Nome="EXT-011198-00107",Descricao = "EXT-011198-00107"},
                        new Exts{Nome="EXT-011198-00108",Descricao = "EXT-011198-00108"},
                        new Exts{Nome="EXT-011198-00110",Descricao = "EXT-011198-00110"},
                        new Exts{Nome="EXT-011198-00112",Descricao = "EXT-011198-00112"},
                        new Exts{Nome="EXT-011198-00113",Descricao = "EXT-011198-00113"},
                        new Exts{Nome="EXT-011198-00114",Descricao = "EXT-011198-00114"},
                        new Exts{Nome="EXT-011198-00117",Descricao = "EXT-011198-00117"},
                        new Exts{Nome="EXT-011198-00118",Descricao = "EXT-011198-00118"},
                        new Exts{Nome="EXT-011198-00119",Descricao = "EXT-011198-00119"},
                        new Exts{Nome="EXT-011198-00120",Descricao = "EXT-011198-00120"},
                        new Exts{Nome="EXT-011198-00121",Descricao = "EXT-011198-00121"},
                        new Exts{Nome="EXT-011198-00122",Descricao = "EXT-011198-00122"},
                        new Exts{Nome="EXT-011198-00123",Descricao = "EXT-011198-00123"},
                        new Exts{Nome="EXT-011198-00124",Descricao = "EXT-011198-00124"}
                    });
            }

            #endregion Exts

            context.SaveChanges();


        }
    }
}
