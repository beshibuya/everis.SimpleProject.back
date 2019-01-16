using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IFaseService
    {
        IEnumerable<Fase> ObterListaPorId(Fase filtro);
    }
}
