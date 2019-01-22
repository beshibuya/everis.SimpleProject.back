using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ProjetoTecnologiaAppSvcGeneric : GenericService<ProjetoTecnologia>, IProjetoTecnologiaService
    {
        public ProjetoTecnologiaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<ProjetoTecnologia>(context);
        }

        public override IEnumerable<ProjetoTecnologia> BuscarPor(ProjetoTecnologia filter)
        {
            return null;
        }

        public IEnumerable<ProjetoTecnologia> TecnologiaProjeto(int projetoId)
        {
            try
            {
                return repository.BuscarPor(p => p.ProjetoId == projetoId, i => i.Tecnologia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}