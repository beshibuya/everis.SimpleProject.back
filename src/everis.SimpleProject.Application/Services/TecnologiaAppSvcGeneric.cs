using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class TecnologiaAppSvcGeneric : GenericService<Tecnologia>
    {
        public TecnologiaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Tecnologia>(context);
        }

        public override IEnumerable<Tecnologia> BuscarPor(Tecnologia filter)
        {
            return null;
        }
    }
}
