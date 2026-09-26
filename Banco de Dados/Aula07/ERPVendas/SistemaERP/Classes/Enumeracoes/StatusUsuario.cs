

using System.ComponentModel;

namespace SistemaERP.Classes.Enumeracoes
{
    internal enum StatusUsuario
    {
        [Description("Aguardando aprovação...")]
        Aguardando,
        [Description("Usuário Aprovado...")]
        Aprovado,
        [Description("Usuário Reprovado...")]
        Reprovado
    }
}
