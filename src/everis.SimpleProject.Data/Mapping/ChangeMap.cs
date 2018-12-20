using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ChangeMap : IEntityTypeConfiguration<Change>
    {
        public void Configure(EntityTypeBuilder<Change> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdChange");
            builder.Property(c => c.Descricao).IsRequired();
            builder.Property(c => c.HorasImpacto).IsRequired();
            builder.Property(c => c.DataHoraCadastro).IsRequired();
            builder.Property(c => c.IdProjeto).IsRequired();
            builder.Property(c => c.DataInativacao);

        }
    }
}
