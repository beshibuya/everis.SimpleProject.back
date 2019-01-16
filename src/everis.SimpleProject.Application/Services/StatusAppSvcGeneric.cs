using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class StatusAppSvcGeneric : GenericService<Status>
    {
        public StatusAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Status>(context);
        }

        public override IEnumerable<Status> BuscarPor(Status filter)
        {
            var nomeBusca = filter?.Descricao;
            var result = repository.BuscarPor(f => f.Descricao.Contains(string.IsNullOrEmpty(nomeBusca) ? f.Descricao : nomeBusca)
            && f.Ativo == filter.Ativo
            );

            return result;
        }
    }
}
