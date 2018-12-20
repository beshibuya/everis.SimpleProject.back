using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Data.EF.Repositories
{
    public class TelefoneRepository : GenericRepository<Telefone>
    {
        public TelefoneRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
