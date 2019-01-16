using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping {

    public class AcessoSiglaMap : BaseMapping<AcessoSigla> {

        public override void Configure(EntityTypeBuilder<AcessoSigla> builder) {
            base.Configure(builder);
            builder.HasOne(c => c.Sigla).WithMany().HasForeignKey(f=>f.SiglaId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Colaborador).WithMany().HasForeignKey(f => f.ColaboradorId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
