using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Model
{
    class Change
    {
        public int IdChange { get; set; }
        public string Descricao { get; set; }
        public short HorasImpacto { get; set; }
        public DateTime DataHoraCadastro { get; set; }
    }
}
