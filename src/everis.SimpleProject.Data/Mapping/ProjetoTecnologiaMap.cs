using everis.SimpleProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace everis.SimpleProject.Data.EF.Mapping
{

    public class ProjetoTecnologiaMap : BaseMapping<ProjetoTecnologia>
    {
        public override void Configure(EntityTypeBuilder<ProjetoTecnologia> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.Tecnologia).WithMany().HasForeignKey(f => f.TecnologiaId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.Projeto).WithMany().HasForeignKey(f => f.ProjetoId).OnDelete(DeleteBehavior.Restrict);         
        }
    }
}
