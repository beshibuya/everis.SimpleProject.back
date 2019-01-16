using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Models
{
    public class AcessoSigla : Entity {

        public int SiglaId { get; set; }
        public Sigla Sigla { get; set; }
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }

        public override void MergeFrom(object other) {
            Sigla = ((AcessoSigla)other).Sigla;
            ColaboradorId = ((AcessoSigla)other).ColaboradorId;
            SiglaId = ((AcessoSigla)other).SiglaId;
            Colaborador = ((AcessoSigla)other).Colaborador;
        }
    }
}
