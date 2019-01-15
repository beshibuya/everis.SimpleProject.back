using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services
{
    public interface ILoginService : IGenericService<Colaborador>
    {
        Colaborador Authenticate(Colaborador filter);
    }
}
