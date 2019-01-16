using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class AcessoSiglaAppSvcGeneric : GenericService<AcessoSigla> {

        public AcessoSiglaAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<AcessoSigla>(context);
        }

        public override IEnumerable<AcessoSigla> BuscarPor(AcessoSigla filter) {
            return null;
        }
    }
}
