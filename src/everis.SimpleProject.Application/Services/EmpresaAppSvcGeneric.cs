using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class EmpresaAppSvcGeneric : GenericService<Empresa>
    {
        public EmpresaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Empresa>(context);
        }

        public override IEnumerable<Empresa> BuscarPor(Empresa filter)
        {
            return null;
        }
    }
}
