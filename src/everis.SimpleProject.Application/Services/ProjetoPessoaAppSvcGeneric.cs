using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoPessoaAppSvcGeneric : GenericService<ProjetoPessoa>, IProjetoPessoaService
    {
        public ProjetoPessoaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<ProjetoPessoa>(context);
        }

        public override IEnumerable<ProjetoPessoa> BuscarPor(ProjetoPessoa filter)
        {
            return null;
        }

        public IEnumerable<ProjetoPessoa> PessoasProjeto(int projetoId)
        {
            try
            {
                return repository.BuscarPor(p => p.ProjetoId == projetoId, i => i.Pessoa);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}