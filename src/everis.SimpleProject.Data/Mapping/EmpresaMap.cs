using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class EmpresaMap : BaseMapping<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {

            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Segmento).IsRequired();
        }
    }
}
