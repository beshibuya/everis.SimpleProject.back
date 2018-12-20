namespace everis.SimpleProject.Domain.Models
{
    public class Empresa : Entity
    {
        public string Nome { get; set; }
        public short Segmento { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Empresa)other).Nome;
        }
    }
}
