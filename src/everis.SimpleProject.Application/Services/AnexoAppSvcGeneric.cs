using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class AnexoAppSvcGeneric : GenericService<Anexo>
    {
        public AnexoAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Anexo>(context);
        }

        //TODO: Testar
        public override IEnumerable<Anexo> BuscarPor(Anexo filter)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
