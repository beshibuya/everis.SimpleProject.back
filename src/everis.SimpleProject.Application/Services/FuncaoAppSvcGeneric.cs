using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class FuncaoAppSvcGeneric : GenericService<Funcao> {

        public FuncaoAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<Funcao>(context);
        }

        public override IEnumerable<Funcao> BuscarPor(Funcao filter) {
            return null;
        }
    }
}
