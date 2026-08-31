
using ZAbstracao.Enumeracao;

namespace ZAbstracao.Classes.Entidades
{
   internal class PessoaFisica : Pessoa
    {

        //Campo
        private double gastos;


        //Propriedades
        public double GastoSaude
        {
            get { return gastos; }
            set { gastos = value; }
        }

        //Construtor
        public PessoaFisica(string nome, double rendaAnual, Contribuinte contribuinte, double gastos) : base(nome, rendaAnual, contribuinte)
        {
            GastoSaude = gastos;

        }
    }
}
