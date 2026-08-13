
namespace Aplicativo_02
{
    internal class Funcionario
    {
        public string nome;
        public double salariobruto;
        public double imposto;
      

        public Funcionario(string nome, double salariobruto, double imposto)
        {
            this.nome = nome;
            this.salariobruto = salariobruto;
            this.imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return salariobruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
             salariobruto += salariobruto * porcentagem/100;
        }
    }
}
