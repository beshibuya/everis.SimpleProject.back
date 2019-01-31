using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class ProjetoSquadAppSvcGeneric : GenericService<ProjetoSquad>, IProjetoSquadService {

        public ProjetoSquadAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<ProjetoSquad>(context);
        }

         

        public override IEnumerable<ProjetoSquad> BuscarPor(ProjetoSquad filter) {
            try {
                return repository.BuscarPor(p => p.ProjetoId == filter.ProjetoId && p.Ativo == filter.Ativo, i => i.Squad, i => i.Projeto);
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public ProjetoSquad ObterProjetoSquad(ProjetoSquad filtro) {
            try {

                if(filtro.ProjetoId == 0) {
                    return new ProjetoSquad();
                }

                return repository.BuscarPor(p => p.ProjetoId == filtro.ProjetoId && p.Ativo == filtro.Ativo, i => i.Squad, i => i.Projeto).FirstOrDefault();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
