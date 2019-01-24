using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IColaboradorService
    {
        IEnumerable<Ferramenta> ListarFerramentasDisponiveis(int colaboradorId);
        IEnumerable<Ferramenta> ListarFerramentasAssociadas(int colaboradorId);
        IEnumerable<Sigla> ListarSiglasDisponiveis(int colaboradorId);
        IEnumerable<Sigla> ListarSiglasAssociadas(int colaboradorId);
    }
}
