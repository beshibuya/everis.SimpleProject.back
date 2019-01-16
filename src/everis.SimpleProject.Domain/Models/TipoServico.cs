using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Models {
    public class TipoServico : Entity {

        public string Descricao { get; set; }

        public override void MergeFrom(object other) {
            Descricao = ((DiretoriaContratante)other).Descricao;
        }
    }
}
