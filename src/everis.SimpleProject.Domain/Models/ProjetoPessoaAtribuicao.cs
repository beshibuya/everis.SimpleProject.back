namespace everis.SimpleProject.Domain.Models
{
    public class ProjetoPessoaAtribuicao : Entity
    {
        public int IdProjetoPessoa { get; set; }
        public ProjetoPessoa ProjetoPessoa { get; set; }
        public int Atribuicao { get; set; }

        public override void MergeFrom(object other)
        {
            Atribuicao = ((ProjetoPessoaAtribuicao)other).Atribuicao;
        }
    }
}