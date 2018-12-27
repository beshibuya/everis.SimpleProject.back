using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IColaboradorService
    {
        IEnumerable<Colaborador> BuscarPor(Colaborador filter);
    }
}
