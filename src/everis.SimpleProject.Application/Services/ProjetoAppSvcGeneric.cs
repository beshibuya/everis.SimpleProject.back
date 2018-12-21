using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoAppSvcGeneric : GenericService<Projeto>, IProjetoService
    {
        public ProjetoAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Projeto>(context);
        }

        //TODO: Testar
        public override IEnumerable<Projeto> BuscarPor(Projeto filter)
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
