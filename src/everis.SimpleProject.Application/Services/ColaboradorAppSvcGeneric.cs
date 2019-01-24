using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Application.Services
{

    public class ColaboradorAppSvcGeneric : GenericService<Colaborador>, IColaboradorService
    {
        public ColaboradorAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Colaborador>(context);
        }


        public override IEnumerable<Colaborador> BuscarPor(Colaborador filter)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Ferramenta> ListarFerramentasAssociadas(int colaboradorId)
        {
            var data = (from ac in ctx.AcessoFerramentas
                        where ac.ColaboradorId == colaboradorId && ac.Ativo
                        select new { fr = ac.Ferramenta }).Select(s => s.fr).ToList();
            return data;
        }

        public IEnumerable<Ferramenta> ListarFerramentasDisponiveis(int colaboradorId)
        {
            var data = (
                    from fr in ctx.Ferramentas
                    join af in (
                        from afr in ctx.AcessoFerramentas
                        where afr.ColaboradorId == colaboradorId && afr.Ativo
                        select new Ferramenta { Id = afr.FerramentaId })
                    on fr.Id equals af.Id into lj
                    from ljr in lj.DefaultIfEmpty()
                    where fr.Ativo
                    select new { Ferramenta = fr, ljr }
                    ).Where(w => w.ljr == null).Select(s => s.Ferramenta).ToList();
            return data;
        }

        public IEnumerable<Sigla> ListarSiglasAssociadas(int colaboradorId) {
            var data = (from ac in ctx.AcessoSiglas
                        where ac.ColaboradorId == colaboradorId && ac.Ativo
                        select new { fr = ac.Sigla }).Select(s => s.fr).ToList();
            return data;
        }

        public IEnumerable<Sigla> ListarSiglasDisponiveis(int colaboradorId) {
            var data = (
                    from fr in ctx.Siglas
                    join af in (
                        from afr in ctx.AcessoSiglas
                        where afr.ColaboradorId == colaboradorId && afr.Ativo
                        select new Sigla { Id = afr.SiglaId })
                    on fr.Id equals af.Id into lj
                    from ljr in lj.DefaultIfEmpty()
                    where fr.Ativo
                    select new { Sigla = fr, ljr }
                    ).Where(w => w.ljr == null).Select(s => s.Sigla).ToList();
            return data;
        }
    }
}
