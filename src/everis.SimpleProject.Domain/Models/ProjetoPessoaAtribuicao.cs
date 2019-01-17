namespace everis.SimpleProject.Domain.Models
{
    public class ProjetoPessoaAtribuicao : Entity
    {
        public string Atribuicao { get; set; }

        public override void MergeFrom(object other)
        {
            Atribuicao = ((ProjetoPessoaAtribuicao)other).Atribuicao;
        }
    }
}