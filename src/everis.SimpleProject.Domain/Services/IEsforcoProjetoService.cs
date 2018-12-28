using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IEsforcoProjetoService
    {
        IEnumerable<EsforcoProjeto> BuscarPor(EsforcoProjeto filter);
    }
}
