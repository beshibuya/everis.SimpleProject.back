using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Data.EF.Mapping {
    class PoloAcessoMap : BaseMapping<PoloAcesso> {

        public override void Configure(EntityTypeBuilder<PoloAcesso> builder) {
            base.Configure(builder);
            builder.Property(c => c.Descricao).IsRequired();

        }
    }
}
