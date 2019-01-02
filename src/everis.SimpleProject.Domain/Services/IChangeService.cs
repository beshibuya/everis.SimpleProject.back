using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface IChangeService
    {
        IEnumerable<Change> BuscarPor(Change filter);
    }
}
