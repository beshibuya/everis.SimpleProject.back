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
            #region Inserts Colaborador

            context.Add(new Colaborador
            {
                Disponivel = false,
                EmailCorporativo = "ricardo@everis.com",
                Funcional = 423947238,
                Funcao = Funcao.SA
            });

            context.Add(new Colaborador
            {
                Disponivel = true,
                EmailCorporativo = "nicholas@everis.com",
                Funcional = 423947876,
                Funcao = Funcao.SA,
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
                ColaboradorId = null
            });

            context.Add(new Pessoa
            {
                Nome = "Ricardo",
                EmpresaId = 1,
                Tipo = TipoPessoa.Colaborador,
                Email = "ricardo@rossetti.com",
                ColaboradorId = 1
            });

            context.Add(new Pessoa
            {
                Nome = "Nicholas",
                EmpresaId = 1,
                Tipo = TipoPessoa.Colaborador,
                Email = "nicholas@torre.com",
                ColaboradorId = 2
            });

            #endregion

            #region Inserts Projeto

            context.Add(new Projeto
            {
                DataInicio = DateTime.Now,
                EscopoProjeto = "Escopo teste",
                QtdHorasServico1 = 1000,
                Nome = "Projeto 1",
                EmpresaId = 1,
                DataPrevista = DateTime.Now.AddDays(7),
                CentroCusto = "EXTNÂOLEMBROORESTO112"
            });

            context.Add(new Projeto
            {
                DataInicio = DateTime.Now,
                EscopoProjeto = "Escopo teste",
                QtdHorasServico1 = 1000,
                Nome = "Projeto 2",
                EmpresaId = 1,
                DataPrevista = DateTime.Now.AddDays(7),
                CentroCusto = "EXTNÂOLEMBROORESTO112"
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

            context.Add(new Change
            {
                Descricao = "Change 1",
                DataHoraCadastro = DateTime.Now,
                ProjetoId = 1,
                QtdHorasServico1 = 13,
                QtdHorasServico2 = 2,
                QtdHorasServico3 = 34,
                Ativo = true
            });

            context.Add(new Change
            {
                Descricao = "Change 2",
                DataHoraCadastro = DateTime.Now,
                ProjetoId = 1,
                QtdHorasServico1 = 344,
                QtdHorasServico2 = 0,
                QtdHorasServico3 = 0,
                Ativo = true
            });

            context.Add(new Change
            {
                Descricao = "Change 3",
                DataHoraCadastro = DateTime.Now,
                ProjetoId = 1,
                QtdHorasServico1 = 0,
                QtdHorasServico2 = 0,
                QtdHorasServico3 = 59,
                Ativo = true
            });

            context.Add(new Change
            {
                Descricao = "Change 4",
                DataHoraCadastro = DateTime.Now,
                ProjetoId = 2,
                QtdHorasServico1 = 5,
                QtdHorasServico2 = 3,
                QtdHorasServico3 = 59,
                Ativo = true
            });

            context.Add(new Change
            {
                Descricao = "Change 5",
                DataHoraCadastro = DateTime.Now,
                ProjetoId = 2,
                QtdHorasServico1 = 544,
                QtdHorasServico2 = 33,
                QtdHorasServico3 = 59,
                Ativo = true
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

            context.SaveChanges();


        }
    }
}
