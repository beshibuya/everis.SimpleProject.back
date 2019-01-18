using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoPessoaAtribuicaoAppSvcGeneric : GenericService<ProjetoPessoaAtribuicao>
    {
        public ProjetoPessoaAtribuicaoAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<ProjetoPessoaAtribuicao>(context);
        }

        public override IEnumerable<ProjetoPessoaAtribuicao> BuscarPor(ProjetoPessoaAtribuicao filter)
        {
            return null;
        }
    }
}
