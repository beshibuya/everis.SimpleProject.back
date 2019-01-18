using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class PerfilAppSvcGeneric : GenericService<Perfil> {

        public PerfilAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<Perfil>(context);
        }

        public override IEnumerable<Perfil> BuscarPor(Perfil filter) {
            return null;
        }
    }
}
