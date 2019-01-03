using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class PessoaAppSvcGeneric : GenericService<Pessoa>
    {
        public PessoaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Pessoa>(context);
        }


        public override IEnumerable<Pessoa> BuscarPor(Pessoa filter)
        {
            try
            {
                var nomeToFind = filter?.Nome;
                var result = repository.BuscarPor(b => b.Nome.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? b.Nome: nomeToFind
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
