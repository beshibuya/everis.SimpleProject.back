using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.NomeUsuario).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(50).IsRequired();
            builder.Property(u => u.SenhaTemporaria).HasMaxLength(50);
            //TODO: TERMINAR
        }
    }
}
