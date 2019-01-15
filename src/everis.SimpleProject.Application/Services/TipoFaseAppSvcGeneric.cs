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
            return null;
        }
    }
}
