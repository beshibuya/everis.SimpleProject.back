using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ProjetoPessoaAtribuicaoMap : BaseMapping<ProjetoPessoaAtribuicao>
    {
        public void Configure(EntityTypeBuilder<ProjetoPessoaAtribuicao> builder)
        {
            builder.Property(c => c.Atribuicao).IsRequired();

            builder.HasOne(o => o.ProjetoPessoa).WithMany().HasForeignKey(c => c.ProjetoPessoaId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
