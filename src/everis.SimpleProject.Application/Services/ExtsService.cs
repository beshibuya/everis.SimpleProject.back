using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ExtsService : GenericService<Exts>
    {
        public ExtsService(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Exts>(context);
        }

        public override IEnumerable<Exts> BuscarPor(Exts filter)
        {
            var toFind = filter?.Nome;
            return repository.BuscarPor(
                b => b.Nome.Contains(string.IsNullOrEmpty(toFind) ? b.Nome : toFind));
        }
    }
}
