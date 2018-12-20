using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class AnexoMap : IEntityTypeConfiguration<Anexo>
    {
        public void Configure(EntityTypeBuilder<Anexo> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdAnexo");
            builder.Property(c => c.Descricao).IsRequired();
            builder.Property(c => c.Path).IsRequired();
            builder.Property(c => c.Tipo).IsRequired();
            builder.Property(c => c.IdProjeto).IsRequired();

        }
    }
}
