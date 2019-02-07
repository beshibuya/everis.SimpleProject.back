using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IProjetoTecnologiaService
    {
        IEnumerable<Tecnologia> TecnologiaProjeto(int projetoId, bool associadas=true);
        IEnumerable<ProjetoTecnologia> AssociarTecnologiaProjeto(int projetoId, IEnumerable<Tecnologia> tecnologias);
    }
}
