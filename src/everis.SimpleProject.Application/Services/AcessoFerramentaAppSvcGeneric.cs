using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services
{
    public class AcessoFerramentaAppSvcGeneric : GenericService<AcessoFerramenta>
    {
        public AcessoFerramentaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<AcessoFerramenta>(context);
        }

        public override IEnumerable<AcessoFerramenta> BuscarPor(AcessoFerramenta filter)
        {
            return null;
        }
    }
}
