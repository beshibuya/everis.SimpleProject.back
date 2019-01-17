using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class AreaContratanteAppSvcGeneric : GenericService<AreaContratante> {

        public AreaContratanteAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<AreaContratante>(context);
        }

        public override IEnumerable<AreaContratante> BuscarPor(AreaContratante filter) {
            return null;
        }
    }
}
