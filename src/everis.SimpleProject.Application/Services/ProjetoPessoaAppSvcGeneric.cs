using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoPessoaAppSvcGeneric : GenericService<ProjetoPessoa>
    {
        public ProjetoPessoaAppSvcGeneric(DbContext context) : base(context)
        {
            repository = new GenericRepository<ProjetoPessoa>(context);
        }

        public override IEnumerable<ProjetoPessoa> BuscarPor(ProjetoPessoa filter)
        {
            return null;
        }
    }
}