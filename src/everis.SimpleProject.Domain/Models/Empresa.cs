using everis.SimpleProject.Domain.Annotations;
using everis.SimpleProject.Domain.Models.Enums;

namespace everis.SimpleProject.Domain.Models
{
    public class Empresa : Entity
    {
        [OrdemExportacao(3)]
        public string Nome { get; set; }
        [OrdemExportacao(4)]
        public TipoSegmento Segmento { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Empresa)other).Nome;
            Segmento = ((Empresa)other).Segmento;
        }
    }
}
