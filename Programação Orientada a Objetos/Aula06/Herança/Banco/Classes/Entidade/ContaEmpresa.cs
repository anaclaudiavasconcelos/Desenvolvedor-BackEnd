using Banco.Classes.Entidade;


namespace Banco.Classes.Entidade
{
    internal class ContaEmpresa : Conta
    {
        //Campo
        private double limite;


        //Propriedade
        public double LimiteDeEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        //Construtor
        public ContaEmpresa(string titularDaConta, int numeroDaConta, double limite) : base(titularDaConta, numeroDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public ContaEmpresa(string titularDaConta, int numeroDaConta, double saldoDaConta, double limite) : base(titularDaConta, numeroDaConta, saldoDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        //Método
        public override string ToString()
        {
            return $"Dados da conta: \n" +
                   $"\tTitular:{TitularDaConta}\n" +
                   $"\tNúmero: {NumeroDaConta}\n" +
                   $"\tSaldo: {SaldoDaConta:c}\n";

        }

        public void Emprestimo(double quantia)
        {
            LimiteDeEmprestimo -= quantia;
            SaldoDaConta += quantia;
        }


    }
}
