using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping {
    class AreaContratanteMap : BaseMapping<AreaContratante> {

        public override void Configure(EntityTypeBuilder<AreaContratante> builder) {
            base.Configure(builder);
            builder.Property(c => c.Descricao).IsRequired();

        }
    }
}
