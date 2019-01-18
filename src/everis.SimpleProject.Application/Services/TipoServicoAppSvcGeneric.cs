using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class TipoServicoAppSvcGeneric : GenericService<TipoServico> {

        public TipoServicoAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<TipoServico>(context);
        }

        public override IEnumerable<TipoServico> BuscarPor(TipoServico filter) {
            return null;
        }
    }
}
