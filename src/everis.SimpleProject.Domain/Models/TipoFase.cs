namespace everis.SimpleProject.Domain.Models
{
    public class TipoFase : Entity
    {
        public string Nome { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((TipoFase)other).Nome;
        }
    }
}
