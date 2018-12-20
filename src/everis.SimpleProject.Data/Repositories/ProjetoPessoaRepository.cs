using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Data.EF.Repositories
{
    public class ProjetoPessoaRepository : GenericRepository<ProjetoPessoa>
    {
        public ProjetoPessoaRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
