using Banco.Interface;

namespace Banco.Classes.Entidade
{
    internal class Conta : IOperacoes
    {
        //Campos
        private int numero;
        private string titular;
        private double saldo;



        //Propriedades
        protected double SaldoDaConta
        {
            get { return saldo; } //get é responsável por retornar o valor do campo saldo
            set { saldo = value; } //set é responsável por receber o valor e atribuir no campo saldo
        }

        protected int NumeroDaConta
        {
            get { return numero; }
            set { numero = value; }
        }

        protected string TitularDaConta
        {
            get { return titular; }
            set { titular = value; }
        }


        //Construtor
        public Conta(string titularDaConta, int numeroDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = 0;
        }

        public Conta(string titularDaConta, int numeroDaConta, double saldoDaConta) : this(titularDaConta, numeroDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }

        //Método
        public virtual void Saque(double quantia)
        {
            SaldoDaConta -= quantia + 5.00;
        }

        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        public override string ToString()
        {
            return $"Dados da conta:\n" +
                $"\tNúmero da conta: {NumeroDaConta}\n" +
                $"\tTitular:{TitularDaConta}\n" +
                $"\tSaldo: {SaldoDaConta:c}\n";
        }


    }
}

