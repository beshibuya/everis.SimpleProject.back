using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ProjetoTipoDemandaMap : BaseMapping<ProjetoTipoDemanda>
    {

        public override void Configure(EntityTypeBuilder<ProjetoTipoDemanda> b)
        {
            base.Configure(b);
            b.HasOne(o => o.Projeto).WithMany().HasForeignKey(f => f.ProjetoId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            b.HasOne(o => o.TipoDemanda).WithMany().HasForeignKey(f => f.TipoDemandaId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }

    }
}
