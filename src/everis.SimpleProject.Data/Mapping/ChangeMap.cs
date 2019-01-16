using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class ChangeMap : BaseMapping<SolicitacaoMudanca>
    {
        public override void Configure(EntityTypeBuilder<SolicitacaoMudanca> builder)
        {

            base.Configure(builder);
            builder.Property(c => c.Descricao).IsRequired();
            builder.Property(c => c.DataHoraCadastro).IsRequired();
            builder.Property(c => c.ProjetoId).IsRequired();
            builder.Property(c => c.DataInativacao);
            builder.Property(c => c.QtdHorasServico1);
            builder.Property(c => c.QtdHorasServico2);
            builder.Property(c => c.QtdHorasServico3);

            builder.HasOne(o => o.Projeto).WithMany().HasForeignKey(f => f.ProjetoId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Pessoa).WithMany().HasForeignKey(f => f.PessoaId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
