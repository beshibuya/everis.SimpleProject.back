using everis.SimpleProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Models {
    public class AreaContratante : Entity {

        public string Descricao { get; set; }

        public override void MergeFrom(object other) {
            Descricao = ((AreaContratante)other).Descricao;
        }
    }
}
