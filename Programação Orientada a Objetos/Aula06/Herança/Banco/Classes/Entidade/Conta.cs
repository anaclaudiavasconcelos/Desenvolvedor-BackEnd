
using Banco.Interface;
using System.Runtime.InteropServices.Marshalling;

namespace Banco.Classes.Entidade
{
    internal class Conta : IOperacoes
    {
		//Campos
		private int numero;
		private string titular;
		private double saldo;

       
        //Propriedades

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
        
        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //Construtor
        public Conta(int numeroDaConta, string titularDaConta) //Construtor com menos argumento.
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
            SaldoDaConta = 0;
        }

        public Conta(int numeroDaConta, string titularDaConta, double saldoDaConta) : this(numeroDaConta, titularDaConta)//ele reaproveitou o outro construtor com menos argumento, é uma herança.
        {
            SaldoDaConta = saldoDaConta;
        }

        public virtual void Saque(double quantia)//virtual habilita fazer a subscrita do método na subclasse.
        {
            SaldoDaConta -= quantia;
        }

        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }
       
    }
}
