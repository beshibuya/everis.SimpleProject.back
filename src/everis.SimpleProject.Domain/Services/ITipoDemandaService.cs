using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface ITipoDemandaService
    {
        IEnumerable<TipoDemanda> TipoDemandaProjeto(int projetoId, bool associadas = true);
        IEnumerable<ProjetoTipoDemanda> AssociarTipoDemandaProjeto(int projetoId, IEnumerable<TipoDemanda> tiposDemandas);
    }
}
