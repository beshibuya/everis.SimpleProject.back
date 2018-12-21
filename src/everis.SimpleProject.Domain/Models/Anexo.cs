using everis.SimpleProject.Domain.Models.Enums;

namespace everis.SimpleProject.Domain.Models
{

    public class Anexo : Entity
    {
        public string Descricao { get; set; }
        public string Path { get; set; }
        public TipoAnexo Tipo { get; set; }
        public int IdProjeto { get; set; }
        public Projeto Projeto { get; set; }

        public override void MergeFrom(object other)
        {
            Descricao = ((Anexo)other).Descricao;
        }
    }
}
