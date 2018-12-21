namespace everis.SimpleProject.Domain.Models.Enums
{
    public enum TipoAnexo
    {
        Abertura = 0,
        Fechamento = 1,
        Evidencia = 2,

    }

    //TODO: IMplementar mais tipos
    public enum TipoSegmento
    {
        Banking = 0,
        Telecomunicacao = 1

    }

    public enum Status
    {
        EmExecucao = 1,
        Concluido = 2,
        Cancelado = 3,
        Congelado = 4,
        PendenteCliente = 5,
        ControleQualidade = 6
    }

    public enum TipoPessoa
    {
        Colaborador = 1,
        Cliente = 2,
        Terceiro = 3
    }

    public enum Funcao
    {
        SA = 1,
        SN = 2,
        STL = 3,
        SPL = 4,
        SK = 5,
        SKL = 6,
        Manager = 7
    }

    public enum Perfil
    {
        Master = 1,
        Lider = 2,
        Colaborador = 3
    }

    public enum TipoTelefone
    {
        Celular = 1,
        Fixo = 2,
        Ramal = 3
    }
}
