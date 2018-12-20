using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class TelefoneAppSvcGeneric : GenericService<Telefone>
    {
        public TelefoneAppSvcGeneric(DbContext context) : base(context)
        {
            repository = new GenericRepository<Telefone>(context);
        }

        public override IEnumerable<Telefone> BuscarPor(Telefone filter)
        {
            return null;
        }
    }
}
