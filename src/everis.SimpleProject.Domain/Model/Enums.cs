namespace everis.SimpleProject.Domain.Model.Enums
{
    public enum eTipoAnexo
    {
        Abertura = 0,
        Fechamento = 1,
        Evidencia = 2,

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

    public enum eTipoPessoa
    {
        Exemplo1 = 1,
        Exemplo2 = 2
    }

    public enum eFuncao
    {
        SA = 1,
        SN = 2,
        STL = 3,
        SPL = 4,
        SK = 5,
        SKL = 6,
        Manager = 7
    }

    public enum ePerfil
    {
        Master = 1,
        Lider = 2,
        Colaborador = 3

    }
}
