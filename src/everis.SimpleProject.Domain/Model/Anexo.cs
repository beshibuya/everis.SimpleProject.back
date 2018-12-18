using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace everis.SimpleProject.Domain.Model
{

    public enum eTipoAnexo
    {
        Fechamento = 1,
        Evidencia = 2
    }
    class Anexo
    {       [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [Required]
            public string Descricao { get; set; }
            [Required]
            public string Path { get; set; }
            [Required]
            public eTipoAnexo Tipo { get; set; }
            [Required]
            public int IdProjeto { get; set; }   // FK 
            public ProjetoModel Projeto { get; set; }  // FK     
    }
}
