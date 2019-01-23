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
            try
            {
                return repository.BuscarPor(p => p.ProjetoId == filter.ProjetoId && p.Ativo == filter.Ativo, i => i.Pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}