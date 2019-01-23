using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services {
    public class AcessoSiglaAppSvcGeneric : GenericService<AcessoSigla>, IAcessoSiglaService {

        public AcessoSiglaAppSvcGeneric(AppDbContext context) : base(context) {
            repository = new GenericRepository<AcessoSigla>(context);
        }

        public List<AcessoSigla> AdicionarListaAcessoSigla(List<Sigla> lstSigla, int colaboradorId) {
            try {

                var lstDbResult = new List<AcessoSigla>();
                AcessoSigla novoAcesso;

                foreach (var item in lstSigla) {

                    novoAcesso = new AcessoSigla();
                    novoAcesso.ColaboradorId = colaboradorId;
                    novoAcesso.SiglaId = item.Id;
                    lstDbResult.Add(repository.Adicionar(novoAcesso));
                }

                return lstDbResult;
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public override IEnumerable<AcessoSigla> BuscarPor(AcessoSigla filter) {
            return null;
        }
    }
}
