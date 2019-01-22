using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class SuperintendenciaAppSvcGeneric : GenericService<Superintendencia>
    {
        public SuperintendenciaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Superintendencia>(context);
        }

        public override IEnumerable<Superintendencia> BuscarPor(Superintendencia filter)
        {
            return null;
        }
    }
}
