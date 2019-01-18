using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class EmpresaMap : BaseMapping<Empresa>
    {
        public override void Configure(EntityTypeBuilder<Empresa> builder)
        {

            base.Configure(builder);
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Segmento).IsRequired();
        }
    }
}
