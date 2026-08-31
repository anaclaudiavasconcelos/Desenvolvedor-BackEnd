

using ZAbstracao.Enumeracao;

namespace ZAbstracao.Classes.Entidades
{
    internal class PessoaJuridica : Pessoa
    {
		//Campos
		private int numerofuncionario;

       
        //Propriedades
        public int NumeroDeFuncionario
		{
			get { return numerofuncionario; }
			set { numerofuncionario = value; }

		}
        //Construtor
        public PessoaJuridica(string nome, double rendaAnual, Contribuinte contribuinte, int numerofuncionario) : base(nome, rendaAnual, contribuinte)
        {
            NumeroDeFuncionario = numerofuncionario;
        }
    }
}
