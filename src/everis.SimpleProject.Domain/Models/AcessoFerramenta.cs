namespace everis.SimpleProject.Domain.Models
{
    public class AcessoFerramenta : Entity
    {
        public int FerramentaId { get; set; }
        public Ferramenta Ferramenta { get; set; }
        public string Sigla { get; set; }

        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }

        public override void MergeFrom(object other)
        {
            Ferramenta = ((AcessoFerramenta)other).Ferramenta;
            Sigla = ((AcessoFerramenta)other).Sigla;
            ColaboradorId = ((AcessoFerramenta)other).ColaboradorId;
            FerramentaId = ((AcessoFerramenta)other).FerramentaId;
            Colaborador = ((AcessoFerramenta)other).Colaborador;

        }
    }
}
