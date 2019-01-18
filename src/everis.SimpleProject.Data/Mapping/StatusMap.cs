using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class StatusMap : BaseMapping<Status>
    {
        public override void Configure(EntityTypeBuilder<Status> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Codigo).IsRequired();
            builder.Property(c => c.Descricao).IsRequired();

        }
    }
}
