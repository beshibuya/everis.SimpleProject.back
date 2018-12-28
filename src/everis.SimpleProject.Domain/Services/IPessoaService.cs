using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IPessoaService
    {
        IEnumerable<Pessoa> BuscarPor(Pessoa filter);
    }
}
