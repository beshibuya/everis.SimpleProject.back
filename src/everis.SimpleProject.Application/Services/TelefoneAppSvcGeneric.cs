using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services {
    public class TelefoneAppSvcGeneric : GenericService<Telefone> , ITelefoneService
    {
        public TelefoneAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<Telefone>(context);
        }

        public IEnumerable<Telefone> AdicionarTelefones(List<Telefone> telefones) {

            try {

                var dbResult = new List<Telefone>();

                foreach (var item in telefones) {
                    dbResult.Add(repository.Adicionar(item));
                }

                return dbResult;
            }
            catch (Exception ex) {

                throw ex;
            }
            
        }

        public override IEnumerable<Telefone> BuscarPor(Telefone filter) {
            try {
                var result = repository.BuscarPor(
                    b => (b.PessoaId == (filter.PessoaId == 0 ? b.PessoaId : filter.PessoaId))
                    );
                return result;
            }
            catch (Exception ex) {
                throw ex;
            }

        }
    }
}
