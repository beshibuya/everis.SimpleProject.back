using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Annotations
{
    public class OrdemExportacao : Attribute
    {
        public int Value;
        public OrdemExportacao(int ordemExportacao)
        {
            this.Value = ordemExportacao;
        }
    }
}
