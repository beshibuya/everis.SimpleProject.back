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

            //#region Inserts Perfis

            //context.Add(new Perfil {

            //});

            //#endregion

            #region Inserts TipoPessoas

            context.Add(new TipoPessoa {
                Descricao = "Colaborador"
            });

            context.Add(new TipoPessoa {
                Descricao = "Cliente"
            });

            context.Add(new TipoPessoa {
                Descricao = "Terceiro"
            });

            #endregion

            #region Inserts TipoTelefones

            context.Add(new TipoTelefone {
                Descricao = "Celular"
            });

            context.Add(new TipoTelefone {
                Descricao = "Fixo"
            });

            context.Add(new TipoTelefone {
                Descricao = "Ramal"
            });

            #endregion

            context.SaveChanges();

            #region Inserts Funcoes

            context.Add(new Funcao {
                Descricao = "SA"
            });

            context.Add(new Funcao {
                Descricao = "SN"
            });

            context.Add(new Funcao {
                Descricao = "STL"
            });

            context.Add(new Funcao {
                Descricao = "SPL"
            });

            context.Add(new Funcao {
                Descricao = "SK"
            });

            context.Add(new Funcao {
                Descricao = "SKL"
            });

            context.Add(new Funcao {
                Descricao = "Manager"
            });

            #endregion

            context.SaveChanges();


            #region Inserts PoloAcesso

            context.Add(new PoloAcesso {
                Descricao = "Centro Tecnologico (CTO)"
            });

            context.Add(new PoloAcesso {
                Descricao = "Centro Empresarial (CEIC)"
            });

            context.Add(new PoloAcesso {
                Descricao = "ACESSO REMOTO"
            });

            #endregion

            context.SaveChanges();

            #region Inserts AreaContratante

            context.Add(new AreaContratante {
                Descricao = "SSRF"
            });

            context.Add(new AreaContratante {
                Descricao = "SSFO"
            });

            context.Add(new AreaContratante {
                Descricao = "SSPOA"
            });

            context.Add(new AreaContratante {
                Descricao = "STIM"
            });

            context.Add(new AreaContratante {
                Descricao = "SQT"
            });

            context.Add(new AreaContratante {
                Descricao = "STIM"
            });

            #endregion

            context.SaveChanges();

            #region Inserts DiretoriaContratante

            context.Add(new DiretoriaContratante {
                Descricao = "DD"
            });

            context.Add(new DiretoriaContratante {
                Descricao = "DESB"
            });

            context.Add(new DiretoriaContratante {
                Descricao = "DCQPTI"
            });

            context.Add(new DiretoriaContratante {
                Descricao = "DDS"
            });


            #endregion

            context.SaveChanges();

            #region Inserts TipoServico

            context.Add(new TipoServico {
                Descricao = "POOL"
            });

            context.Add(new TipoServico {
                Descricao = "RFP(Consultoria)"
            });

            #endregion

            context.SaveChanges();

            #region Inserts Colaborador

            context.Add(new Colaborador
            {
                Disponivel = false,
                EmailCorporativo = "ricardo@everis.com",
                FuncaoId = 1,
                AreaContratanteId = 2,
                PoloAcessoId = 1,
                TipoServicoId = 1,
                Senha = "everis"
            });

            context.Add(new Colaborador
            {
                Disponivel = true,
                EmailCorporativo = "nicholas@everis.com",
                FuncaoId = 2,
                AreaContratanteId = 1,
                PoloAcessoId = 2,
                TipoServicoId = 2

            });

            context.SaveChanges();

            #endregion

            #region Inserts Empresa

            context.Add(new Empresa
            {
                Nome = "empresa 1",
                Segmento = TipoSegmento.Banking
            });

            context.Add(new Empresa
            {
                Nome = "empresa 2",
                Segmento = TipoSegmento.Banking
            });

            #endregion

            #region Inserts Superintendencia

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
            #endregion

            #region Inserts Pessoa


            context.Add(new Pessoa {
                Nome = "David Rezende Torres",
                EmpresaId = 1,
                TipoId = 3,
                Email = "david@rezende.com",
                Funcional = 423947876,
                ColaboradorId = null,
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
                ColaboradorId = 1,
                Sexo = "Masculino",
                Funcional = 544633677

            });

            context.Add(new Pessoa
            {
                Nome = "Nicholas",
                EmpresaId = 1,
                TipoId = 1,
                Email = "nicholas@torre.com",
                ColaboradorId = 2,
                Sexo = "Masculino"
            });

            context.Add(new Pessoa {
                Nome = "Maria das Dores",
                EmpresaId = 1,
                TipoId = 3,
                Email = "maria_das_dores@doeu.com",
                ColaboradorId = 2,
                Sexo = "Feminino",
                DiretoriaId = 2
            });

            #endregion

            #region Inserts Status

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

            #endregion

            context.SaveChanges();

            #region Inserts Projeto

            context.Add(new Projeto
            {
                DataInicio = DateTime.Now,
                EscopoProjeto = "Escopo teste",
                QtdHorasServico1 = 1000,
                Nome = "Projeto 1",
                EmpresaId = 1,
                DataPrevista = DateTime.Now.AddDays(7),
                CodigoProjeto = "1",
                StatusId = 1,
                DataRecebida = DateTime.Now,
                Tecnologia = "Tecnologia teste",
                Sigla = "Sigla teste",
                RespOutsourcing = "RespOutsourcing teste",
                RespTI = "RespTI teste",
                RespGerente = "RespGerente teste",
                Tamanho = 'P',
                TipoDemanda = "Servico 1 teste",
                Tarifa = "Tarifa teste",
                Superintendencia = "Superintendencia",
            });

            context.Add(new Projeto
            {
                DataInicio = DateTime.Now,
                EscopoProjeto = "Escopo teste",
                QtdHorasServico1 = 1000,
                Nome = "Projeto 2",
                EmpresaId = 1,
                DataPrevista = DateTime.Now.AddDays(7),
                CodigoProjeto = "2",
                StatusId = 1,
                DataRecebida= DateTime.Now,
                Tecnologia= "Tecnologia teste",
                Sigla= "Sigla teste",
                RespOutsourcing= "RespOutsourcing teste",
                RespTI= "RespTI teste",
                RespGerente= "RespGerente teste",
                Tamanho= 'P',
                TipoDemanda= "Servico 1 teste",
                Tarifa= "Tarifa teste",
                Superintendencia= "Superintendencia",
                DiretoriaId = 1

            });

            #endregion


            context.SaveChanges();

            #region Inserts Ferramentas

            context.Add(new Ferramenta {
                Descricao = "Visual Studio",
            });

            context.Add(new Ferramenta
            {
                Descricao = "RTC",
            });

            context.Add(new Ferramenta
            {
                Descricao = "Angular",
            });

            context.Add(new Ferramenta
            {
                Descricao = "GIT",
            });

            context.Add(new Ferramenta
            {
                Descricao = "Confluence",
            });

            context.Add(new Ferramenta
            {
                Descricao = "Jira",
            });

            #endregion

            #region Inserts Change

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
                PessoaId = 2
            });

            context.Add(new SolicitacaoMudanca
            {
                Descricao = "Change 4",
                DataHoraCadastro = DateTime.Now,
                ProjetoId = 2,
                QtdHorasServico1 = 5,
                QtdHorasServico2 = 3,
                QtdHorasServico3 = 59,
                Ativo = true,
                PessoaId = 2
            });

            context.Add(new SolicitacaoMudanca
            {
                Descricao = "Change 5",
                DataHoraCadastro = DateTime.Now,
                ProjetoId = 2,
                QtdHorasServico1 = 544,
                QtdHorasServico2 = 33,
                QtdHorasServico3 = 59,
                Ativo = true,
                PessoaId = 1
            });

            #endregion

            #region Inserts Tipo Fase

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

            #endregion

            #region Inserts Sigla

            context.Add(new Sigla {
                Descricao = "Sigla_01"
            });

            context.Add(new Sigla {
                Descricao = "Sigla_02"
            });

            context.Add(new Sigla {
                Descricao = "Sigla_03"
            });
            #endregion
            #region Inserts Atribuição

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
            #endregion

            context.SaveChanges();


        }
    }
}
