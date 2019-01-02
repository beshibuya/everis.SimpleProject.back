using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services
{
    public class EmpresaAppSvcGeneric : GenericService<Empresa>
    {
        public EmpresaAppSvcGeneric(AppDbContext context) : base(context)
        {
        }

        public override IEnumerable<Empresa> BuscarPor(Empresa filter)
        {
            return null;
        }
    }
}
