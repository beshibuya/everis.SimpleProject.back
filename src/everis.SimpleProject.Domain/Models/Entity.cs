using System;

namespace everis.SimpleProject.Domain.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataInativacao { get; set; }
        public abstract void MergeFrom(object other);

        public Entity()
        {
            Ativo = true;
        }
    }
}
