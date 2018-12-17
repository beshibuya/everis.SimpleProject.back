using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleProcess.Models
{
    public class ProjetoPessoa
    {
        [Key]
        public int IdProjetoPessoa { get; set; }

        [ForeignKey("IdProjeto")]
        public int IdProjeto { get; set; }

        [ForeignKey("IdPessoa")]
        public int IdPessoa { get; set; }
    }
}