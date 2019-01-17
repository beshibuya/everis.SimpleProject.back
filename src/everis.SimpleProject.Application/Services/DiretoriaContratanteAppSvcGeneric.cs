using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class DiretoriaContratanteAppSvcGeneric : GenericService<DiretoriaContratante> {

        public DiretoriaContratanteAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<DiretoriaContratante>(context);
        }

        public override IEnumerable<DiretoriaContratante> BuscarPor(DiretoriaContratante filter) {
            throw new NotImplementedException();
        }
    }
}
