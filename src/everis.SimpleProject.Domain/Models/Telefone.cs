using everis.SimpleProject.Domain.Models.Enums;

namespace everis.SimpleProject.Domain.Models
{
    public class Telefone : Entity
    {
        public string NumeroTelefone { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public override void MergeFrom(object other)
        {
            return;
        }
    }
}
