using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Data.EF.Repositories
{
    public class ProjetoRepository : GenericRepository<Usuario>
    {
        public ProjetoRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
