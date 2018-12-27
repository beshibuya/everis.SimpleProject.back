using everis.SimpleProject.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class ProjetoPessoa : Entity
    {
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public override void MergeFrom(object other)
        {
            return;
        }
    }
}