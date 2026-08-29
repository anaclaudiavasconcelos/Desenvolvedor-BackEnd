
using ZAbstracao.Classes.Entidades;
using ZAbstracao.Interfaces;

namespace ZAbstracao.Classes.Servicos
{
    internal class Imposto : IAssinatura
    {
        public double CalPessoaFisica(double renda)
        {
            if (renda < 20000.00)
            {
                return renda * 0.15;
            }
            else
            {
                return renda * 0.25;
            }
           
        }

        public double CalPessoaJuridica(int funcionario)
        {
            if (funcionario)
            {
                
            }


        }
    }
}
