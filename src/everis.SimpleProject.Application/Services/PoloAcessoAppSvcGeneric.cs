using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class PoloAcessoAppSvcGeneric : GenericService<PoloAcesso> {

        public PoloAcessoAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<PoloAcesso>(context);
        }

        public override IEnumerable<PoloAcesso> BuscarPor(PoloAcesso filter) {
            return null;
        }
    }
}
