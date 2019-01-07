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
                Funcao = Funcao.SA,
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
                Nome = "Everis é com e minúsculo",
                Segmento = TipoSegmento.Banking
            });

            #endregion

            #region Inserts Pesoa


            context.Add(new Pessoa
            {
                Nome = "David Rezende Torres",
                EmpresaId = 1,
                Tipo = TipoPessoa.Terceiro,
                Email = "david@rezende.com"
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
                Nome = "Simple Process",
                EmpresaId = 1,
                DataPrevista = DateTime.Now.AddDays(7),
                CentroCusto = "EXTNÂOLEMBROORESTO112"
            });

            #endregion
            context.SaveChanges();


        }
    }
}

