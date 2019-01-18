using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping {
    public class PerfilMap : BaseMapping<Perfil> {

        public override void Configure(EntityTypeBuilder<Perfil> builder) {
            base.Configure(builder);
            builder.Property(c => c.Descricao).IsRequired();

        }
    }
}
