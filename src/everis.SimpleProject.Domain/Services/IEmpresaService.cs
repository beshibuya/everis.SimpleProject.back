using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Services
{
    public interface IEmpresaService
    {
        IEnumerable<Empresa> BuscarPor(Empresa filter);
    }
}
