using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IProjetoTecnologiaService
    {
        IEnumerable<ProjetoTecnologia> TecnologiaProjeto(int projetoId);
    }
}
