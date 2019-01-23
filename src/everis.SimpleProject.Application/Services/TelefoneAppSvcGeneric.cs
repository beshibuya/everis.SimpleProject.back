using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace everis.SimpleProject.Application.Services {
    public class TelefoneAppSvcGeneric : GenericService<Telefone> , ITelefoneService
    {
        public TelefoneAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<Telefone>(context);
        }

        public List<Telefone> AdicionarTelefones(List<Telefone> telefones, int pessoaId) {

            try {

                var dbResult = new List<Telefone>();

                foreach (var item in telefones) {
                    item.Tipo = null;
                    item.Pessoa = null;
                    item.PessoaId = pessoaId;
                    var retorno = repository.Adicionar(item);
                    dbResult.Add(retorno);
                }
                repository.SaveChanges();

                return dbResult;
            }
            catch (Exception ex) {

                throw ex;
            }
            
        }

        //public override Telefone ObterPorId(int id) {
        //    var res = ctx.Telefones.Include(i => i.Tipo).FirstOrDefault(f => f.Id == id);
        //    return res;
        //}

        public override IEnumerable<Telefone> BuscarPor(Telefone filter) {
            try {
                var result = repository.BuscarPor(b => b.PessoaId == filter.PessoaId, i => i.Tipo).ToList();
                return result;
            }
            catch (Exception ex) {
                throw ex;
            }

        }
    }
}
