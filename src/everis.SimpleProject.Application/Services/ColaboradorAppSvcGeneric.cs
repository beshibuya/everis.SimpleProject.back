using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ColaboradorAppSvcGeneric : GenericService<Colaborador>
    {
        public ColaboradorAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Colaborador>(context);
        }


        public override IEnumerable<Colaborador> BuscarPor(Colaborador filter)
        {
            try
            {
                var nomeToFind = filter?.Pessoa.Nome;
                var result = repository.BuscarPor(b => b.Pessoa.Nome.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? b.Pessoa.Nome : nomeToFind
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
