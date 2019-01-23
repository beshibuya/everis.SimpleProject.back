using everis.SimpleProject.Data.EF;
using everis.SimpleProject.Data.EF.Repositories;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Application.Services
{
    public class AcessoFerramentaAppSvcGeneric : GenericService<AcessoFerramenta>, IAcessoFerramentaService
    {
        public AcessoFerramentaAppSvcGeneric(AppDbContext context) : base(context)
        {
            repository = new GenericRepository<AcessoFerramenta>(context);
        }

        public List<AcessoFerramenta> AdicionarListaAcessoFerramenta(List<Ferramenta> lstFerramenta, int colaboradorId) {

            try {

                var lstDbResult = new List<AcessoFerramenta>();
                AcessoFerramenta novoAcesso;

                foreach (var item in lstFerramenta) {

                    novoAcesso = new AcessoFerramenta();
                    novoAcesso.Colaborador = null;
                    novoAcesso.Ferramenta = null;
                    novoAcesso.ColaboradorId = colaboradorId;
                    novoAcesso.FerramentaId = item.Id;
                    lstDbResult.Add(repository.Adicionar(novoAcesso));
                }

                repository.SaveChanges();

                return lstDbResult;
            }
            catch (Exception ex) {

                throw ex;
            }

        }

        public override IEnumerable<AcessoFerramenta> BuscarPor(AcessoFerramenta filter)
        {
            return null;
        }
    }
}
