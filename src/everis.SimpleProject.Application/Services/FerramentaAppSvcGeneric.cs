using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services
{
    public class FerramentaAppSvcGeneric : GenericService<Ferramenta>
    {
        public FerramentaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Ferramenta>(context);
        }

        public override IEnumerable<Ferramenta> BuscarPor(Ferramenta filter)
        {
            return null;
        }
    }
}
