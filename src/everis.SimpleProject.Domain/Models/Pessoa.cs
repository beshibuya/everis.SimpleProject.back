using everis.SimpleProject.Domain.Models.Enums;
using System.Collections.Generic;

namespace everis.SimpleProject.Domain.Models
{
    public class Pessoa : Entity
    {
        public int? DiretoriaId { get; set; }
        public DiretoriaContratante Diretoria { get; set; }
        public int? ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public int TipoId { get; set; }
        public TipoPessoa Tipo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Documento { get; set; }
        public long CPF { get; set; }
        public long Rg { get; set; }
        public string OrgaoEmissor { get; set; }
        public string UFRg { get; set; }
        public string FotoPath { get; set; }
        public int Funcional { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Pessoa)other).Nome;
            FotoPath = ((Pessoa)other).FotoPath;
            CPF = ((Pessoa)other).CPF;
            Tipo = ((Pessoa)other).Tipo;
            Documento = ((Pessoa)other).Documento;
            EmpresaId = ((Pessoa)other).EmpresaId;
            Empresa = ((Pessoa)other).Empresa;
            Rg = ((Pessoa)other).Rg;
            OrgaoEmissor = ((Pessoa)other).OrgaoEmissor;
            UFRg = ((Pessoa)other).UFRg;
            Sexo = ((Pessoa)other).Sexo;
            Tipo = ((Pessoa)other).Tipo;
            TipoId = ((Pessoa)other).TipoId;
        }
    }
}
