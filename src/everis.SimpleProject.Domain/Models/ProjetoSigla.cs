namespace everis.SimpleProject.Domain.Models
{
    public class ProjetoSigla : Entity
    {
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
        public int SiglaId { get; set; }
        public Sigla Sigla { get; set; }
        public override void MergeFrom(object other)
        {
            return;
        }
    }
}
