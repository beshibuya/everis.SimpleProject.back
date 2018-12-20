using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Repositories
{
    public class EsforcoProjetoRepository : GenericRepository<EsforcoProjeto>
    {
        public EsforcoProjetoRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
