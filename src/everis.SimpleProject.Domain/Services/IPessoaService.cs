using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Services {
    public interface IPessoaService {
        IEnumerable<Pessoa> ObterGestoresTecnicos();
        dynamic ObterPessoaColaborador(int pessoaId);
        IEnumerable<dynamic> FiltrarPessoaColaborador(Pessoa filter);
        void AtualizarPessoaColaborador(int pessoaId, int tipoPessoa, List<Telefone> lstNovoTelefone, List<Ferramenta> lstNovaFerramenta, List<Sigla> lstNovaSigla);
    }
}
