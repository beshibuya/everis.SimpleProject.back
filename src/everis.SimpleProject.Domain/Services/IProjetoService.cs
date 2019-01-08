using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IProjetoService
    {
        IEnumerable<dynamic> ListarProjetosComChange(Projeto filtro);
    }
}
