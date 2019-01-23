using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Services {
    public interface IAcessoSiglaService {
        List<AcessoSigla> AdicionarListaAcessoSigla(List<Sigla> lstSigla, int colaboradorId);
    }
}
