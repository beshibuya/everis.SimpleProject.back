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
                Funcao = Funcao.SA,
                AreaContratanteId = 2,
                PoloAcessoId = 1,
                DiretoriaContratanteId = 3,
                TipoServicoId = 1
                Funcional = 423947238,
                Funcao = Funcao.SA,
                Senha = "1234"
            });

            context.Add(new Colaborador
            {
                Disponivel = true,
                EmailCorporativo = "nicholas@everis.com",
                Funcao = Funcao.SA,
                AreaContratanteId = 1,
                PoloAcessoId = 2,
                DiretoriaContratanteId = 1,
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

            #region Inserts Pessoa


            context.Add(new Pessoa
            {
                Nome = "David Rezende Torres",
                EmpresaId = 1,
                Tipo = TipoPessoa.Terceiro,
                Email = "david@rezende.com",
                Funcional = 423947876,
                ColaboradorId = null,
                Sexo = "Masculino"
            });

            context.Add(new Pessoa
            {
                Nome = "Ricardo",
                EmpresaId = 1,
                Tipo = TipoPessoa.Colaborador,
                Email = "ricardo@rossetti.com",
                ColaboradorId = 1,
                Sexo = "Masculino",
                Funcional = 544633677

            });

            context.Add(new Pessoa
            {
                Nome = "Nicholas",
                EmpresaId = 1,
                Tipo = TipoPessoa.Colaborador,
                Email = "nicholas@torre.com",
                ColaboradorId = 2,
                Sexo = "Masculino"
            });

            context.Add(new Pessoa {
                Nome = "Maria das Dores",
                EmpresaId = 1,
                Tipo = TipoPessoa.Terceiro,
                Email = "maria_das_dores@doeu.com",
                ColaboradorId = 2,
                Sexo = "Feminino",
            });

            #endregion

            #region Inserts Status

            context.Add(new Status
            {
                Codigo = "APR",
                Descricao = "Em Aprovação"
            });

            context.Add(new Status
            {
                Codigo = "EXE",
                Descricao = "Em Execução"
            });

            context.Add(new Status
            {
                Codigo = "CN",
                Descricao = "Cancelado"
            });

            context.Add(new Status
            {
                Codigo = "CO",
                Descricao = "Concluído"
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
                CentroCusto = "EXTNÂOLEMBROORESTO112",
                CodigoProjeto = "1",
                StatusId = 1
            });

            context.Add(new Projeto
            {
                DataInicio = DateTime.Now,
                EscopoProjeto = "Escopo teste",
                QtdHorasServico1 = 1000,
                Nome = "Projeto 2",
                EmpresaId = 1,
                DataPrevista = DateTime.Now.AddDays(7),
                CentroCusto = "EXTNÂOLEMBROORESTO112",
                CodigoProjeto = "2",
                StatusId = 1
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


            context.SaveChanges();


        }
    }
}
