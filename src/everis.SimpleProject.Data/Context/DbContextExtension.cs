using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
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

            context.Add(new Empresa
            {
                Nome = "Everis é com e minúsculo",
                Segmento = TipoSegmento.Banking
            });

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

            context.Add(new Pessoa
            {
                Nome = "David Rezende Torres",
                EmpresaId = 1,
                Tipo = TipoPessoa.Colaborador
            });

            context.SaveChanges();
        }
    }
}
