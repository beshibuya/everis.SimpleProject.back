using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Repositories;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Application.Services
{
    public class TipoDemandaService : GenericService<TipoDemanda>, ITipoDemandaService
    {
        readonly IGenericRepository<ProjetoTipoDemanda> repoPrjTpDem;
        public TipoDemandaService(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<TipoDemanda>(context);
            repoPrjTpDem = new GenericRepository<ProjetoTipoDemanda>(context);
        }

        public IEnumerable<ProjetoTipoDemanda> AssociarTipoDemandaProjeto(int projetoId, IEnumerable<TipoDemanda> tiposDemandas)
        {
            var atual = ObterTipoDemandasAssociadas(projetoId).ToList();
            var toRemove = atual.Except(tiposDemandas).ToList();
            var toAdd = tiposDemandas.Except(atual).ToList();

            if (toRemove.Any())
            {
                var curr =
                    repoPrjTpDem.BuscarPor(t => t.ProjetoId == projetoId && t.Ativo).ToList()
                    .Join(
                        toRemove,
                        d => d.TipoDemandaId,
                        r => r.Id,
                        (TipoDemandaProjeto, TipoDemanda) => new { TipoDemandaProjeto, TipoDemanda }
                        ).Where(w => w.TipoDemanda.Id == w.TipoDemandaProjeto.TipoDemandaId);

                foreach (var r in curr)
                    repository.Remover(r.TipoDemandaProjeto.Id);
            }

            foreach (var a in toAdd)
            {
                var objToAdd = new ProjetoTipoDemanda { ProjetoId = projetoId, TipoDemandaId = a.Id };
                repoPrjTpDem.Adicionar(objToAdd);
            }
            repository.SaveChanges();
            return repoPrjTpDem.BuscarPor(b => b.ProjetoId == projetoId && b.Ativo);
        }

        public override IEnumerable<TipoDemanda> BuscarPor(TipoDemanda filter)
        {
            var toFind = filter?.Nome;
            return repository.BuscarPor(b => b.Ativo
            && b.Nome.Contains(string.IsNullOrEmpty(toFind) ? b.Nome : toFind)
            );
        }

        public IEnumerable<TipoDemanda> TipoDemandaProjeto(int projetoId, bool associadas = true)
        {
            try
            {
                var data = associadas ? ObterTipoDemandasAssociadas(projetoId)
                    : ObterTipoDemandasDisponiveis(projetoId);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private IEnumerable<TipoDemanda> ObterTipoDemandasAssociadas(int projetoId)
        {
            var data = repoPrjTpDem.BuscarPor(p => p.ProjetoId == projetoId && p.Ativo, i => i.TipoDemanda).Select(s => s.TipoDemanda);
            return data;
        }

        private IEnumerable<TipoDemanda> ObterTipoDemandasDisponiveis(int projetoId)
        {
            var data = (from t in ctx.TipoDemandas
                        join pt in
                        (from ptx in ctx.ProjetosTipoDemanda
                         where ptx.ProjetoId == projetoId && ptx.Ativo
                         select ptx)
                        on t.Id equals pt.TipoDemandaId into lj
                        from ptj in lj.DefaultIfEmpty()
                        select new { TipoDemanda = t, projetoTipoDemanda = ptj })
                       .Where(x => x.projetoTipoDemanda == null)
                       .Select(s => s.TipoDemanda)
                       .ToList();
            return data;
        }
    }
}
