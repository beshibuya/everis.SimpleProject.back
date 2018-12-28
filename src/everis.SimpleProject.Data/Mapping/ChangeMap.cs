using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ChangeMap : BaseMapping<Change>
    {
        public void Configure(EntityTypeBuilder<Change> builder)
        {

            base.Configure(builder);
            builder.Property(c => c.Descricao).IsRequired();
            builder.Property(c => c.HorasImpacto).IsRequired();
            builder.Property(c => c.DataHoraCadastro).IsRequired();
            builder.Property(c => c.ProjetoId).IsRequired();
            builder.Property(c => c.DataInativacao);

            builder.HasOne(o => o.Projeto).WithMany().HasForeignKey().OnDelete(DeleteBehavior.Restrict);

        }
    }
}
