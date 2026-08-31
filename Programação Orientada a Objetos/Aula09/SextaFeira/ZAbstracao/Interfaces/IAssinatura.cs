

using ZAbstracao.Classes.Entidades;

namespace ZAbstracao.Interfaces
{
    internal interface IAssinatura
    {
        public double CalcularImposto(PessoaFisica pessoafisica);

        public double CalcularImposto(PessoaJuridica pessoajuridica);

    }

}
