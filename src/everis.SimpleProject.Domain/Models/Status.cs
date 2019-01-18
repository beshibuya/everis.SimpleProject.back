
namespace everis.SimpleProject.Domain.Models
{
    public class Status : Entity
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }

        public override void MergeFrom(object other)
        {
            Codigo = ((Status)other).Codigo;
            Descricao = ((Status)other).Descricao;
        }
    }
}
