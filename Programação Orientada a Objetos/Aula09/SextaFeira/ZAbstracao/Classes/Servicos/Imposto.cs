
using ZAbstracao.Classes.Entidades;
using ZAbstracao.Interfaces;

namespace ZAbstracao.Classes.Servicos
{
    internal class Imposto : IAssinatura
    {
        public double CalcularImposto(PessoaFisica pessoafisica)
        {
            if (pessoafisica.RendaAnual < 20000)
            {
                return (pessoafisica.RendaAnual * 0.15) - (pessoafisica.GastoSaude * 0.50);
            }
            else
            {
                return (pessoafisica.RendaAnual * 0.25) - (pessoafisica.GastoSaude * 0.50);
            }
        }

        public double CalcularImposto(PessoaJuridica pessoajuridica)
        {
            if (pessoajuridica.NumeroDeFuncionario <= 10)
            {
                return pessoajuridica.RendaAnual * 0.16;
            }
            else
            {
                return pessoajuridica.RendaAnual * 0.14;
            }
        }
    }
}
