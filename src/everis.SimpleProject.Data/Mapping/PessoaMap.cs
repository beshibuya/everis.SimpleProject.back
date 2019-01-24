using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class PessoaMap : BaseMapping<Pessoa>
    {
        public override void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Sexo).IsRequired();
            builder.HasOne(c => c.Diretoria).WithMany().HasForeignKey(f => f.DiretoriaId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.Tipo).WithMany().HasForeignKey(f => f.TipoId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
