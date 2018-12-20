using everis.SimpleProject.Domain.Models.Enums;

namespace everis.SimpleProject.Domain.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public eTipoPessoa Tipo { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public long CPF { get; set; }
        public string FotoPath { get; set; }
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }

        public override void MergeFrom(object other)
        {
            Nome = ((Pessoa)other).Nome;
            FotoPath = ((Pessoa)other).FotoPath;
            CPF = ((Pessoa)other).CPF;
            Tipo = ((Pessoa)other).Tipo;
            Documento = ((Pessoa)other).Documento;
            IdEmpresa = ((Pessoa)other).IdEmpresa;
            Empresa = ((Pessoa)other).Empresa;
        }
    }
}
