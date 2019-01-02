using System;
using System.Collections.Generic;
using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace everis.SimpleProject.Application.Services
{
    public class ChangeAppSvcGeneric : GenericService<Change>
    {
        public ChangeAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Change>(context);
        }

        public override IEnumerable<Change> BuscarPor(Change filter)
        {
            try
            {
                var nomeToFind = filter?.Projeto.Nome ;
                var result = repository.BuscarPor(b => b.Projeto.Nome.Contains(
                    string.IsNullOrEmpty(nomeToFind) ? b.Projeto.Nome : nomeToFind
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
