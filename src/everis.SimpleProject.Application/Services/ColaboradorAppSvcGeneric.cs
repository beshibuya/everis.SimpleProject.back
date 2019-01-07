using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ColaboradorAppSvcGeneric : GenericService<Colaborador>
    {
        public ColaboradorAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Colaborador>(context);
        }


        public override IEnumerable<Colaborador> BuscarPor(Colaborador filter)
        {
            try
            {
             
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
