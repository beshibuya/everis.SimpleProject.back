using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class TipoPessoaAppSvcGeneric : GenericService<TipoPessoa> {

        public TipoPessoaAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<TipoPessoa>(context);
        }

        public override IEnumerable<TipoPessoa> BuscarPor(TipoPessoa filter) {
            return null;
        }
    }
}
