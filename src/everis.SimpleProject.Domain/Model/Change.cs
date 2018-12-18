﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Model
{
    public class Change
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdChange { get; set; }

        public string Descricao { get; set; }

        public short HorasImpacto { get; set; }

        public DateTime DataHoraCadastro { get; set; }
    }
}
