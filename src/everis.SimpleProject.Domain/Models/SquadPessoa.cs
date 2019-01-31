namespace everis.SimpleProject.Domain.Models
{
    public class SquadPessoa : Entity
    {
        public int SquadId { get; set; }
        public Squad Squad { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public override void MergeFrom(object other)
        {
            Ativo = ((ProjetoPessoa)other).Ativo;
        }
    }
}
