using System;

namespace everis.SimpleProject.Domain.Models
{
    public class TipoDemanda : Entity, IEquatable<TipoDemanda>
    {
        public string Nome { get; set; }

        public override void MergeFrom(object other )
        {
            Nome = ((TipoDemanda)other).Nome;
        }

        public bool Equals(TipoDemanda other)
        {
            if (other is null)
                return false;
            return this.Nome == other.Nome && this.Id == other.Id;
        }

        public override bool Equals(object obj) => Equals(obj as Tecnologia);
        public override int GetHashCode() => (Nome, Id).GetHashCode();
    }
}
