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
            builder.HasOne(o => o.Pessoa).WithMany(o => o.ProjetosPessoas).IsRequired().OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Projeto).WithMany(o => o.ProjetosPessoas).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
