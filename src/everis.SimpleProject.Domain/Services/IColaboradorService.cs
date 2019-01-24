using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IColaboradorService
    {
        IEnumerable<Ferramenta> ListarFerramentasDisponiveis(int colaboradorId);
        IEnumerable<Ferramenta> ListarFerramentasAssociadas(int colaboradorId);
        //IEnumerable<Pessoa> ListarDadosColaborador(string email);
    }
}
