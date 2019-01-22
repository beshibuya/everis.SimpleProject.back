using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Models
{
    public class Tecnologia : Entity
    {
        public string Nome { get; set; }
        
        public override void MergeFrom(object other)
        {
            Nome = ((Tecnologia)other).Nome;
        }
    }   
}
