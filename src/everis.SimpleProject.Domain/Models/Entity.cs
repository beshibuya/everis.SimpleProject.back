using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }

        public Entity()
        {
            Ativo = true;
        }
    }
}
