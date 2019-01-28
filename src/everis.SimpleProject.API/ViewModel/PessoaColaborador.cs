using everis.SimpleProject.Domain.Models;
using System.Collections.Generic;

namespace everis.SimpleProject.API.ViewModel
{
    public class PessoaColaborador
    {
        public Pessoa pessoa { get; set; }
        public Colaborador colaborador { get; set; }

        public List<Telefone> Telefones { get; set; }
        public List<Ferramenta> FerramentasAssociadas { get; set; }
        public List<Sigla> SiglasAssociadas { get; set; }
    }
}
