using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoSiglaService : GenericService<ProjetoSigla>, IProjetoSiglaService
    {
        public ProjetoSiglaService(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<ProjetoSigla>(context);
        }

        public IEnumerable<ProjetoSigla> AssociarSiglaProjeto(int projetoId, IEnumerable<Sigla> siglas)
        {
            var atual = ObterSiglasAssociadas(projetoId).ToList();
            var toRemove = atual.Except(siglas).ToList();
            var toAdd = siglas.Except(atual).ToList();

            if (toRemove.Any())
            {
                var curr =
                    repository.BuscarPor(t => t.ProjetoId == projetoId && t.Ativo).ToList()
                    .Join(
                        toRemove,
                        d => d.SiglaId,
                        r => r.Id,
                        (SiglaProjeto, Sigla) => new { SiglaProjeto, Sigla }
                        ).Where(w => w.Sigla.Id == w.SiglaProjeto.SiglaId);

                foreach (var r in curr)
                    repository.Remover(r.SiglaProjeto.Id);
            }

            foreach (var a in toAdd)
            {
                var objToAdd = new ProjetoSigla { ProjetoId = projetoId, SiglaId = a.Id };
                repository.Adicionar(objToAdd);
            }
            repository.SaveChanges();
            return repository.BuscarPor(b => b.ProjetoId == projetoId && b.Ativo);
        }

        public override IEnumerable<ProjetoSigla> BuscarPor(ProjetoSigla filter)
        {
            return repository.BuscarPor(f => f.Ativo && f.ProjetoId == filter.ProjetoId);
        }

        public IEnumerable<Sigla> SiglaProjeto(int projetoId, bool associadas = true)
        {
            try
            {
                var data = associadas ? ObterSiglasAssociadas(projetoId)
                    : ObterSiglasDisponiveis(projetoId);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private IEnumerable<Sigla> ObterSiglasAssociadas(int projetoId)
        {
            var data = repository.BuscarPor(p => p.ProjetoId == projetoId && p.Ativo, i => i.Sigla).Select(s => s.Sigla);
            return data;
        }

        private IEnumerable<Sigla> ObterSiglasDisponiveis(int projetoId)
        {
            var data = (from t in ctx.Siglas
                        join pt in
                        (from ptx in ctx.ProjetosSiglas
                         where ptx.ProjetoId == projetoId && ptx.Ativo
                         select ptx)
                        on t.Id equals pt.SiglaId into lj
                        from ptj in lj.DefaultIfEmpty()
                        select new { Sigla = t, projetoSigla = ptj })
                       .Where(x => x.projetoSigla == null)
                       .Select(s => s.Sigla)
                       .ToList();
            return data;
        }
    }
}
