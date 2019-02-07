using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IProjetoSiglaService
    {
        IEnumerable<Sigla> SiglaProjeto(int projetoId, bool associadas = true);
        IEnumerable<ProjetoSigla> AssociarSiglaProjeto(int projetoId, IEnumerable<Sigla> siglas);
    }
}
