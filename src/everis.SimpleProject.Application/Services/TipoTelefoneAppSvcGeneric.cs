using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class TipoTelefoneAppSvcGeneric : GenericService<TipoTelefone> {

        public TipoTelefoneAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<TipoTelefone>(context);
        }

        public override IEnumerable<TipoTelefone> BuscarPor(TipoTelefone filter) {
            return null;
        }
    }
}
