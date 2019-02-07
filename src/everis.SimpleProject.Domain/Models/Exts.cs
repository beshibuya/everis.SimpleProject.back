namespace everis.SimpleProject.Domain.Models
{
    public class Exts : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public override void MergeFrom(object other)
        {
            Nome = ((Exts)other).Nome;
            Descricao = ((Exts)other).Descricao;
        }
    }
}
