
namespace Banco.Classes.Entidade
{
    internal sealed class ContaPoupanca : Conta //ContaPoupança é uma classe selada, isso impede que ela seja herdada.
    {
        //Campos
        private double taxa;


        //Propriedades
        protected double TaxaDeJuros
        {
            get { return taxa; }
            set { taxa = value; }
        }

        //Construtor
        public ContaPoupanca(string titularDaConta, int numeroDaConta, double taxa) : base(titularDaConta, numeroDaConta)
        {
            TaxaDeJuros = taxa;
        }

        public ContaPoupanca(string titularDaConta, int numeroDaConta, double saldoDaConta, double taxa) : base(titularDaConta, numeroDaConta, saldoDaConta)
        {
            TaxaDeJuros = taxa;
        }

        //Método

        public override void Saque(double quantia)
        {
            SaldoDaConta -= quantia + (quantia * TaxaDeJuros);

        }

        public void AtualizacaoDeSaldo(double quantia)
        {
            Console.WriteLine($"Saldo atualizado: {SaldoDaConta:c}");
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
