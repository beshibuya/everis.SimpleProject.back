using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Application.Services
{
    public class FaseAppSvcGeneric : GenericService<Fase>, IFaseService
    {
        public FaseAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Fase>(context);
        }

        public override IEnumerable<Fase> BuscarPor(Fase filter)
        {
            try
            {
                var result = ctx.Fases.Include(X => X.TipoFase).Include(X => X.Pessoa).Where(
                    b => (filter.CodigoFase == 0 ||  b.CodigoFase == filter.CodigoFase)
                    && (b.ProjetoId == (filter.ProjetoId == 0 ? b.ProjetoId : filter.ProjetoId))
                    && b.Ativo == filter.Ativo);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Fase> ObterListaPorId(Fase filter)
        {
            try
            {
                var nomeToFind = filter.Projeto?.Nome;
                var result = repository.BuscarPor(
                    b => (b.ProjetoId == (filter.ProjetoId == 0 ? b.ProjetoId : filter.ProjetoId)));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
