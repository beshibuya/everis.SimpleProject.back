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

        //public IEnumerable<Pessoa> ListarDadosColaborador(string email)
        //{
        //    var data = (
        //            from col in ctx.Colaboradors
        //            join pes in ctx.Pessoas on pes
        //            where col.EmailCorporativo = email && pes.Ativo
        //            sele

        //            (
        //                from pes in ctx.Pessoas
        //                where col.EmailCorporativo == email && pes.Ativo
        //                select new Pessoa { Id = col.Id, Nome = n })
        //            on fr.Id equals af.Id into lj
        //            from ljr in lj.DefaultIfEmpty()
        //            where fr.Ativo
        //            select new { Ferramenta = fr, ljr }
        //            ).Where(w => w.ljr == null).Select(s => s.Ferramenta).ToList();
        //    return data;


        //    var data = (from ac in ctx.Pessoas
        //                where ac.Colaborador.EmailCorporativo == email && ac.Ativo
        //                select new Pessoa { Id = ac.Id, Nome = ac.Nome, Email = ac.Email, Funcional = ac.Funcional,
        //                CPF = ac.CPF, Documento = ac.Documento, }).ToList();
        //    return data;
        //}
    }
}
