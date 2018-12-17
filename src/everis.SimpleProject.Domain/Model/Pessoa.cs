using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace everis.SimpleProject.Domain.Model
{
    class Pessoa
    { 
        public enum eTipoPessoa
        {
            Exemplo1 = 1,
            Exemplo2 = 2
        }

        public class Anexo
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int IdPessoa { get; set; }
            [Required]
            public string Nome { get; set; }
            [Required]
            public eTipoPessoa Tipo { get; set; }
            public string Email { get; set; }
            public string Documento { get; set; }
            public long CPF { get; set; }
            [Required]
            public bool Ativo { get; set; }
            public string FotoPath { get; set; }
            [Required]
            public int IdEmpresa { get; set; }  // FK 
            public Empresa Empresa { get; set; } // FK 
        }
    }
}
