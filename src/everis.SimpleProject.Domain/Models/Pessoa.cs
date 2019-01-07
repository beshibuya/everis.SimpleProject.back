using everis.SimpleProject.Domain.Models.Enums;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public TipoPessoa Tipo { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public long CPF { get; set; }
        public string FotoPath { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public List<ProjetoPessoa> ProjetosPessoas { get; set; }
        public List<Telefone> Telefones { get; set; }
        public int? ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Pessoa)other).Nome;
            FotoPath = ((Pessoa)other).FotoPath;
            CPF = ((Pessoa)other).CPF;
            Tipo = ((Pessoa)other).Tipo;
            Documento = ((Pessoa)other).Documento;
            EmpresaId = ((Pessoa)other).EmpresaId;
            Empresa = ((Pessoa)other).Empresa;
        }
    }
}
