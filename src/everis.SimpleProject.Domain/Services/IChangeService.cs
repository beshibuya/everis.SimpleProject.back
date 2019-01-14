using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface ISolicitacaoMudancaService
    {
        IEnumerable<SolicitacaoMudanca> ObterListaPorId(SolicitacaoMudanca filtro);
    }
}
