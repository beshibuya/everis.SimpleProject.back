using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;

namespace everis.SimpleProject.Application.Services
{
    public class ChangeAppSvcGeneric : GenericService<Change>, IChangeService
    {
        public ChangeAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<Change>(context);
        }

        public override IEnumerable<Change> BuscarPor(Change filter)
        {
            try
            {
                var descricaoToFind = filter.Descricao ;
                var result = repository.BuscarPor(
                    b => (b.Descricao.Contains(string.IsNullOrEmpty(descricaoToFind) ? b.Descricao : descricaoToFind))
                    && (b.ProjetoId == (filter.ProjetoId == 0 ? b.ProjetoId : filter.ProjetoId))
                    && b.Ativo == filter.Ativo
                    );
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Change> ObterListaPorId(Change filter)
        {
            try
            {
                var nomeToFind = filter.Projeto?.Nome;
                var result = repository.BuscarPor(
                    b => (b.ProjetoId == (filter.ProjetoId == 0 ? b.ProjetoId : filter.ProjetoId)));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
