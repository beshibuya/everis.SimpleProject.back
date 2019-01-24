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

                #endregion

                context.SaveChanges();
            }
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
                    Nome = "Itau",
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
                    Nome = "David Rezende Torres",
                    EmpresaId = 1,
                    TipoId = 3,
                    Email = "david@rezende.com",
                    Funcional = 423947876,
                    Sexo = "Masculino",
                    DiretoriaId = 1,
                    GestorTecnico = true
                });

                context.Add(new Pessoa
                {
                    Nome = "Ricardo",
                    EmpresaId = 1,
                    TipoId = 1,
                    Email = "ricardo@rossetti.com",
                    Sexo = "Masculino",
                    Funcional = 544633677

                });

                context.Add(new Pessoa
                {
                    Nome = "Nicholas",
                    EmpresaId = 1,
                    TipoId = 1,
                    Email = "nicholas@torre.com",
                    Sexo = "Masculino"
                });

                context.Add(new Pessoa
                {
                    Nome = "Maria das Dores",
                    EmpresaId = 1,
                    TipoId = 1,
                    Email = "maria_das_dores@doeu.com",
                    Sexo = "Feminino",
                    DiretoriaId = 2
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts Colaborador

            if (!context.Colaboradors.Any())
            {
                context.Add(new Colaborador
                {
                    EmailCorporativo = "ricardo@everis.com",
                    FuncaoId = 1,
                    AreaContratanteId = 2,
                    PoloAcessoId = 1,
                    TipoServicoId = 1,
                    Senha = "everis",
                    PessoaId = 4
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

                context.Add(new Sigla
                {
                    Descricao = "Sigla_01"
                });

                context.Add(new Sigla
                {
                    Descricao = "Sigla_02"
                });

                context.Add(new Sigla
                {
                    Descricao = "Sigla_03"
                });
                context.SaveChanges();
            }
            #endregion

            #region Inserts Projeto

            if (!context.Projetos.Any())
            {
                context.Add(new Projeto
                {
                    DataInicio = DateTime.Now,
                    EscopoProjeto = "Escopo teste",
                    QtdHorasServico1 = 1000,
                    Nome = "Projeto 1",
                    Ext = "EXT-00000000000",
                    EmpresaId = 1,
                    DataPrevista = DateTime.Now.AddDays(7),
                    CodigoProjeto = "1",
                    StatusId = 1,
                    DataRecebida = DateTime.Now,
                    TecnologiaId = 1,
                    SiglaId = 1,
                    RespOutsourcing = "RespOutsourcing teste",
                    RespTI = "RespTI teste",
                    RespGerente = "RespGerente teste",
                    Tamanho = 'P',
                    TipoDemanda = "Servico 1 teste",
                    Tarifa = "Tarifa teste",
                    SuperintendenciaId = 1,
                    DiretoriaId = 2,
                    StatusProposta = "N/A",
                    DataProposta =DateTime.Now
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

            #region Inserts Change
            if (!context.Changes.Any())
            {

                context.Add(new SolicitacaoMudanca
                {
                    Descricao = "Change 1",
                    DataHoraCadastro = DateTime.Now,
                    ProjetoId = 1,
                    QtdHorasServico1 = 13,
                    QtdHorasServico2 = 2,
                    QtdHorasServico3 = 34,
                    Ativo = true,
                    PessoaId = 1
                });

                context.Add(new SolicitacaoMudanca
                {
                    Descricao = "Change 2",
                    DataHoraCadastro = DateTime.Now,
                    ProjetoId = 1,
                    QtdHorasServico1 = 344,
                    QtdHorasServico2 = 0,
                    QtdHorasServico3 = 0,
                    Ativo = true,
                    PessoaId = 1
                });

                context.Add(new SolicitacaoMudanca
                {
                    Descricao = "Change 3",
                    DataHoraCadastro = DateTime.Now,
                    ProjetoId = 1,
                    QtdHorasServico1 = 0,
                    QtdHorasServico2 = 0,
                    QtdHorasServico3 = 59,
                    Ativo = true,
                    PessoaId = 1
                });

                context.Add(new SolicitacaoMudanca
                {
                    Descricao = "Change 4",
                    DataHoraCadastro = DateTime.Now,
                    ProjetoId = 1,
                    QtdHorasServico1 = 5,
                    QtdHorasServico2 = 3,
                    QtdHorasServico3 = 59,
                    Ativo = true,
                    PessoaId = 1
                });

                context.Add(new SolicitacaoMudanca
                {
                    Descricao = "Change 5",
                    DataHoraCadastro = DateTime.Now,
                    ProjetoId = 1,
                    QtdHorasServico1 = 544,
                    QtdHorasServico2 = 33,
                    QtdHorasServico3 = 59,
                    Ativo = true,
                    PessoaId = 1
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
            }
            #endregion

            #region Inserts Comunidade
            if (!context.Comunidades.Any())
            {

                context.Add(new Sigla
                {
                    Descricao = "Finanças"
                });
                context.Add(new Sigla
                {
                    Descricao = "Créditos e Garantias"
                });
            }
            #endregion


            context.SaveChanges();


        }
    }
}
