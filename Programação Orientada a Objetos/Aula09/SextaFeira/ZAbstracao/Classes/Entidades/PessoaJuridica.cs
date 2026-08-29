

namespace ZAbstracao.Classes.Entidades
{
    internal class PessoaJuridica : Pessoa
    {
		//Campos
		private int funcionario;

       
        //Propriedades
        public int NumeroDeFuncionario
		{
			get { return funcionario; }
			set { funcionario = value; }

		}
        //Construtor
        public PessoaJuridica(int numeroDeFuncionario)
        {
            NumeroDeFuncionario = numeroDeFuncionario;
        }
    }
}
