using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleProcess.Models
{
    public class ProjetoPessoaAtribuicao
    {
        [Key]
        public int IdProjetoPessoa { get; set; }
        public int Atribuicao { get; set; }  
    }
}