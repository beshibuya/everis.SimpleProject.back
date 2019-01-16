using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class SiglaAppSvcGeneric : GenericService<Sigla> {

        public SiglaAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<Sigla>(context);
        }

        public override IEnumerable<Sigla> BuscarPor(Sigla filter) {
            return null; ;
        }
    }
}
