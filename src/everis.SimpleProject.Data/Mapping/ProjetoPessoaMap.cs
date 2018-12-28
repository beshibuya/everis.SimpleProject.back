using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{

    public class ProjetoPessoaMap : BaseMapping<ProjetoPessoa>
    {
        public void Configure(EntityTypeBuilder<ProjetoPessoa> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.ProjetoId).IsRequired();
            builder.Property(c => c.PessoaId).IsRequired();

            builder.HasOne(o => o.Pessoa).WithMany().HasForeignKey().OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Projeto).WithMany().HasForeignKey().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
