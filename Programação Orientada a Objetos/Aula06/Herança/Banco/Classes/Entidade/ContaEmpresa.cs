
namespace Banco.Classes.Entidade
{
    internal class ContaEmpresa : Conta
    {
		//Campos
		private double limite;

       
        //Propriedades
        protected double LimiteDeEmprestimo
		{
			get { return limite; }
			set { limite = value; }
		}

        //Construtores

        public ContaEmpresa(int numeroDaConta, string titularDaConta, double limite) : base(numeroDaConta, titularDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public ContaEmpresa(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        //Método
        public override string ToString() //Método de subscrita. override faz a subscrita
        {
            return $"Dados da conta: \n" + $"\tTitular: {TitularDaConta}\n" + $"\t Número: {NumeroDaConta}\n" + $"\t Saldo: {SaldoDaConta:c}\n" + $"\t Limite: {LimiteDeEmprestimo:c}\n";
        }

        public void Emprestimo(double quantia)
        {
            LimiteDeEmprestimo -= quantia;
            SaldoDaConta += quantia;
        }

    }
}
