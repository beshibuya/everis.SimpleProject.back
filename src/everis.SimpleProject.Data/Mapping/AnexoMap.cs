using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class AnexoMap : IEntityTypeConfiguration<Anexo>
    {
        public void Configure(EntityTypeBuilder<Anexo> builder)
        {
            //builder.HasKey(c => c.Id);
            //builder.Property(c => c.Id).HasColumnName("IdUsuario");
            //builder.Property(c => c.NomeUsuario).IsRequired();
            //builder.Property(c => c.Senha).IsRequired();
            //builder.Property(c => c.SenhaTemporaria).IsRequired();
            //builder.Property(c => c.Email).IsRequired();
            //builder.Property(c => c.DataCadastro).IsRequired();
            //builder.Property(c => c.DataDesativacao);


        }
    }
}
