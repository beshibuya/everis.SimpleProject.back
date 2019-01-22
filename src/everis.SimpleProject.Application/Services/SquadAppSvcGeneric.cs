using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class SquadAppSvcGeneric : GenericService<Squad>
    {
        public SquadAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Squad>(context);
        }

        public override IEnumerable<Squad> BuscarPor(Squad filter)
        {
            var nomeBusca = filter?.Nome;
            var idComunidade = filter?.ComunidadeId;
            var result = repository.BuscarPor(f => f.Nome.Contains(string.IsNullOrEmpty(nomeBusca) ? f.Nome : nomeBusca) && 
                (idComunidade ==  null || idComunidade == 0 || f.ComunidadeId == (int)idComunidade) &&
                f.Ativo == filter.Ativo
            );
                
            return result;
        }
    }
}
