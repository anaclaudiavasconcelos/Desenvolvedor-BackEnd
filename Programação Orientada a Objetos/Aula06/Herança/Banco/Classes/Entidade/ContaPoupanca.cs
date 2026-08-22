
namespace Banco.Classes.Entidade
{
    internal sealed class ContaPoupanca : Conta //sealed - selado, quando coloca na classe faz que não seja permitido a herança da classe ContaPoupança.
    {
		//Campos
		private double taxa;

        
        //Propriedades
        protected double TaxaDeJuros
		{
			get { return taxa; }
			set { taxa = value; }
		}

        //Construtores
        public ContaPoupanca(int numeroDaConta, string titularDaConta, double taxa) : base(numeroDaConta, titularDaConta)//base - Chamada da implementação do membro da superclasse na subclasse.
        {
            TaxaDeJuros = taxa;
        }

        public ContaPoupanca(int numeroDaConta, string titularDaConta, double saldoDaConta, double taxa) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            TaxaDeJuros = taxa;
        }

        //Métodos
        public override void Saque(double quantia)
        {
                SaldoDaConta -= quantia + (quantia * TaxaDeJuros);
        }
        
               
    }
}
