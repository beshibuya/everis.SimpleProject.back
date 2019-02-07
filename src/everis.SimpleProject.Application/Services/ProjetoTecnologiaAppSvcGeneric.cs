using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoTecnologiaAppSvcGeneric : GenericService<ProjetoTecnologia>, IProjetoTecnologiaService
    {
        public ProjetoTecnologiaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<ProjetoTecnologia>(context);
        }

        public IEnumerable<ProjetoTecnologia> AssociarTecnologiaProjeto(int projetoId, IEnumerable<Tecnologia> tecnologias)
        {
            var atual = ObterTecnologiasAssociadas(projetoId).ToList();
            var toRemove = atual.Except(tecnologias).ToList();
            var toAdd = tecnologias.Except(atual).ToList();

            if (toRemove.Any())
            {
                var curr =
                    repository.BuscarPor(t => t.ProjetoId == projetoId && t.Ativo).ToList()
                    .Join(
                        toRemove,
                        d => d.TecnologiaId,
                        r => r.Id,
                        (tecnologiaProjeto, tecnologia) => new { tecnologiaProjeto, tecnologia }
                        ).Where(w => w.tecnologia.Id == w.tecnologiaProjeto.TecnologiaId);
                    
                foreach (var r in curr)
                    repository.Remover(r.tecnologiaProjeto.Id);
            }

            foreach (var a in toAdd)
            {
                var objToAdd = new ProjetoTecnologia { ProjetoId = projetoId, TecnologiaId = a.Id };
                repository.Adicionar(objToAdd);
            }
            repository.SaveChanges();
            return repository.BuscarPor(b => b.ProjetoId == projetoId && b.Ativo);

        }

        public override IEnumerable<ProjetoTecnologia> BuscarPor(ProjetoTecnologia filter)
        {
            return null;
        }

        public IEnumerable<Tecnologia> TecnologiaProjeto(int projetoId, bool associadas = true)
        {
            try
            {
                var data = associadas ? ObterTecnologiasAssociadas(projetoId)
                    : ObterTecnologiasDisponiveis(projetoId);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private IEnumerable<Tecnologia> ObterTecnologiasAssociadas(int projetoId)
        {
            var data = repository.BuscarPor(p => p.ProjetoId == projetoId && p.Ativo, i => i.Tecnologia).Select(s => s.Tecnologia);
            return data;
        }

        private IEnumerable<Tecnologia> ObterTecnologiasDisponiveis(int projetoId)
        {
            var data = (from t in ctx.Tecnologia
                        join pt in
                        (from ptx in ctx.ProjetoTecnologia
                         where ptx.ProjetoId == projetoId && ptx.Ativo
                         select ptx)
                        on t.Id equals pt.TecnologiaId into lj
                        from ptj in lj.DefaultIfEmpty()
                        select new { tecnologia = t, projetoTecnologia = ptj })
                       .Where(x => x.projetoTecnologia == null)
                       .Select(s => s.tecnologia)
                       .ToList();
            return data;
        }
    }
}