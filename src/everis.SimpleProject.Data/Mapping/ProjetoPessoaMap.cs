using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{

    public class ProjetoPessoaMap : BaseMapping<ProjetoPessoa>
    {
        public void Configure(EntityTypeBuilder<ProjetoPessoa> builder)
        {
            builder.Property(c => c.IdProjeto).IsRequired();
            builder.Property(c => c.IdPessoa).IsRequired();

            builder.HasOne(o => o.Pessoa).WithMany().HasForeignKey().OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Projeto).WithMany().HasForeignKey().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
