namespace everis.SimpleProject.Domain.Models
{
    public class Comunidade : Entity
    {
        public string Nome { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Comunidade)other).Nome;
        }
    }
}
