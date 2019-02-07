namespace everis.SimpleProject.Domain.Models
{
    public class ProjetoTipoDemanda : Entity
    {
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
        public int TipoDemandaId { get; set; }
        public TipoDemanda TipoDemanda { get; set; }

        public override void MergeFrom(object other)
        {
            return;
        }
    }
}
