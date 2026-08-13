

namespace Aplicativo_01
{
    internal class Retangulo
    {
        public double largura;
        public double altura;

        //Construtor
        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return 2 * (largura + altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }
}
