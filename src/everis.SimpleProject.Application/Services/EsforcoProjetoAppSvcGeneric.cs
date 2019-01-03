using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class EsforcoProjetoAppSvcGeneric : GenericService<EsforcoProjeto>
    {
        public EsforcoProjetoAppSvcGeneric(DbContext context) : base(context)
        {
            repository = new GenericRepository<EsforcoProjeto>(context);
        }

        public override IEnumerable<EsforcoProjeto> BuscarPor(EsforcoProjeto filter)
        {
            try
            {
                var nomeToFind = filter?.ProjetoPessoa.Pessoa.Nome;
                var result = repository.BuscarPor(b => b.ProjetoPessoa.Pessoa.Nome.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? b.ProjetoPessoa.Pessoa.Nome : nomeToFind
                    ));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
