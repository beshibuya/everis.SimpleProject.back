
namespace everis.SimpleProject.Domain.Models
{
    public class Atribuicao : Entity
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }

        public override void MergeFrom(object other)
        {
            Codigo = ((Atribuicao)other).Codigo;
            Descricao = ((Atribuicao)other).Descricao;
        }
    }
}
