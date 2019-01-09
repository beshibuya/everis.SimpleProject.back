using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class TelefoneAppSvcGeneric : GenericService<Telefone>
    {
        public TelefoneAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Telefone>(context);
        }

        public override IEnumerable<Telefone> BuscarPor(Telefone filter)
        {
            try
            {
                var result = repository.BuscarPor(
                    b => (b.PessoaId == (filter.PessoaId == 0 ? b.PessoaId : filter.PessoaId))
                    );
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
