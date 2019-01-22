using everis.SimpleProject.Domain.Annotations;

namespace everis.SimpleProject.Domain.Models
{
    public class Comunidade : Entity
    {
        [OrdemExportacao(3)]
        public string Nome { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Comunidade)other).Nome;
        }
    }
}
