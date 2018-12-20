using everis.SimpleProject.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Models
{
    public class ProjetoPessoa : Entity
    {
        public int IdProjeto { get; set; }
        public Projeto Projeto { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        public override void MergeFrom(object other)
        {
            return;
        }
    }
}