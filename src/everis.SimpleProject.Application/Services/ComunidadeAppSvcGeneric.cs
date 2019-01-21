using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ComunidadeAppSvcGeneric : GenericService<Comunidade>
    {
        public ComunidadeAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Comunidade>(context);
        }

        public override IEnumerable<Comunidade> BuscarPor(Comunidade filter)
        {
            var nomeBusca = filter?.Nome;
            var result = repository.BuscarPor(f => f.Nome.Contains(string.IsNullOrEmpty(nomeBusca) ? f.Nome : nomeBusca)
            && f.Ativo == filter.Ativo
            );
                
            return result;
        }
    }
}
