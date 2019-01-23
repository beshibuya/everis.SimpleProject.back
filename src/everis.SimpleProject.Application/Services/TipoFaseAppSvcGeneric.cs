using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class TipoFaseAppSvcGeneric : GenericService<TipoFase>
    {
        public TipoFaseAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<TipoFase>(context);
        }

        public override IEnumerable<TipoFase> BuscarPor(TipoFase filter)
        {
            try
            {
                var nomeToFind = filter?.Nome;
                var result = repository.BuscarPor(b => b.Nome.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? b.Nome : nomeToFind
                    ));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
