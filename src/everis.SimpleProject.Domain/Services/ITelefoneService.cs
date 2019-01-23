using System;
using System.Collections.Generic;
using System.Text;
using everis.SimpleProject.Domain.Models;

namespace everis.SimpleProject.Domain.Services {

    public interface ITelefoneService {
        List<Telefone> AdicionarTelefones(List<Telefone> telefones, int pessoaId);
    }
}
