using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Models {
    public class ProjetoSquad : Entity {
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
        public int? SquadId { get; set; }
        public Squad Squad { get; set; }

        public override void MergeFrom(object other) {
            ProjetoId = ((ProjetoSquad)other).ProjetoId;
            Projeto = ((ProjetoSquad)other).Projeto;
            SquadId = ((ProjetoSquad)other).SquadId;
            Squad = ((ProjetoSquad)other).Squad;
            return;
        }
    }
}
