using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ProjetoSiglaMap : BaseMapping<ProjetoSigla>
    {
        public override void Configure(EntityTypeBuilder<ProjetoSigla> b)
        {

            base.Configure(b);
            b.HasOne(c => c.Sigla).WithMany().HasForeignKey(f => f.SiglaId);
            b.HasOne(c => c.Projeto).WithMany().HasForeignKey(f => f.ProjetoId);
        }
    }
}
