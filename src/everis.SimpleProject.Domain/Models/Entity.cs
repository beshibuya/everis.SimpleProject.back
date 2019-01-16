using everis.SimpleProject.Domain.Annotations;
using System;

namespace everis.SimpleProject.Domain.Models
{
    public abstract class Entity
    {
        [OrdemExportacao(0)]
        public int Id { get; set; }
        [OrdemExportacao(1)]
        public bool Ativo { get; set; }
        [OrdemExportacao(2)]
        public DateTime? DataInativacao { get; set; }
        public abstract void MergeFrom(object other);

        public Entity()
        {
            Ativo = true;
        }
    }
}
