
namespace Moeda
{
    internal static class ConversorDeMoeda
    {
        
        public static double IOF = 0.06;



        public static double Pagamento(double cotacao, double compra)
        {
            return cotacao * compra * (1 + IOF);
        }
    }


}
