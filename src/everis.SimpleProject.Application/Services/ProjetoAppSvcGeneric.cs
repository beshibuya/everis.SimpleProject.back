using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoAppSvcGeneric : GenericService<Projeto>, IProjetoService
    {
        public ProjetoAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Projeto>(context);
        }

        public override Projeto ObterPorId(int id)
        {
            var res = ctx.Projetos.Include(i => i.ProjetosPessoas).FirstOrDefault(f => f.Id == id);
            return res;
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
