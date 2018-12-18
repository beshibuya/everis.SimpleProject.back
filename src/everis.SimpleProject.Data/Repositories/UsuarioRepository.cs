using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Data.EF.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>
    {
        public UsuarioRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
