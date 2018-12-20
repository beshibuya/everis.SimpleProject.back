using System;
using System.Collections.Generic;
using System.Text;

namespace everis.SimpleProject.Domain.Models
{
    class Retorno
    {
        public Retorno()
        {
            Parameters = new Dictionary<string, object>();
        }
        public int Codigo { get; set; }
        public string Mensagem { get; set; }
        public string Data { get; set; }
        public new Dictionary<string, object> Parameters { get; set; }

    }
}
