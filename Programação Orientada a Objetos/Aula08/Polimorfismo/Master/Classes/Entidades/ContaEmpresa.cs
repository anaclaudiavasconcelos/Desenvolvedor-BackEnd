namespace Master.Classes.Entidades
{
    internal class ContaEmpresa : Conta
    {
        //Campos
        private double limite;

        //Propriedade
        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        //Construtor
        public ContaEmpresa(string titularDaConta, int numeroDaConta, double limite) : base(titularDaConta, numeroDaConta)
        {
            LimiteEmprestimo = limite;
        }

        public ContaEmpresa(string titularDaConta, int numeroDaConta, double saldoDaConta, double limite) : base(titularDaConta, numeroDaConta, saldoDaConta)
        {
            LimiteEmprestimo = limite;
        }

        //Métodos
        public void Emprestimo(double qtd)
        {
            LimiteEmprestimo -= qtd;
            SaldoDaConta += qtd;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Limite para emprestimo: {LimiteEmprestimo:c}");
        }
    }
}
