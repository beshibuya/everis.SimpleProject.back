using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class SquadPessoaAppSvcGeneric : GenericService<SquadPessoa>
    {
        public SquadPessoaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<SquadPessoa>(context);
        }

        public override IEnumerable<SquadPessoa> BuscarPor(SquadPessoa filter)
        {
            var idSquad = filter?.SquadId;
            var result = repository.BuscarPor(f => f.SquadId == idSquad && f.Ativo == filter.Ativo, i => i.Pessoa);                
            return result;
        }
    }
}
