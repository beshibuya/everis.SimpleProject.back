using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{
    public class SquadPessoaMap : BaseMapping<SquadPessoa>
    {
        public override void Configure(EntityTypeBuilder<SquadPessoa> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.Pessoa).WithMany().HasForeignKey(f=>f.PessoaId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Squad).WithMany().HasForeignKey(f=>f.SquadId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
