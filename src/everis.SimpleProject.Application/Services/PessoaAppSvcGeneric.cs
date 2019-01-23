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
    public class PessoaAppSvcGeneric : GenericService<Pessoa>, IPessoaService
    {
        public PessoaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Pessoa>(context);
        }

        public override IEnumerable<Pessoa> ObterTodos()
        {
            try
            {

            var res = ctx.Pessoas.Include(i => i.Colaborador).ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override Pessoa ObterPorId(int id) {
            try {

             
                var result = repository.BuscarPor(b => b.Id == id, i => i.Colaborador).FirstOrDefault();
                return result;

            }
            catch (Exception ex) {

                throw ex;
            }
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

        public IEnumerable<Pessoa> ObterGestoresTecnicos() {

            var gestores = new List<Pessoa>();
            var todasPessoas = repository.ObterTodos();

            foreach (var item in todasPessoas) {
                if(item.GestorTecnico == true) {
                    gestores.Add(item);
                }
            }

            return gestores;
        }
    }
}
