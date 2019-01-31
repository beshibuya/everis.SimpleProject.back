using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping {
    class ProjetoSquadMap : BaseMapping<ProjetoSquad> {
        public override void Configure(EntityTypeBuilder<ProjetoSquad> builder) {
            base.Configure(builder);     
            builder.HasOne(o => o.Projeto).WithMany().HasForeignKey(f => f.ProjetoId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Squad).WithMany().HasForeignKey(c => c.SquadId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
