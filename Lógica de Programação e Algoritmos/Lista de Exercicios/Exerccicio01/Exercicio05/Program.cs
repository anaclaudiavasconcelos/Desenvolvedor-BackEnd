
//Declaração de variáveis
using System.ComponentModel.Design;

double primeiro, segundo, terceiro;


try
{
    //Entrada de dados
    Console.Write("Digite o 1º lado do triângulo: ");
    primeiro = double.Parse(Console.ReadLine());
    Console.Write("Digite o 2º lado do triângulo: ");
    segundo = double.Parse(Console.ReadLine());
    Console.Write("Digite o 3º lado do triângulo: ");
    terceiro = double.Parse(Console.ReadLine());

    if ((primeiro + segundo > terceiro) && (primeiro + terceiro > segundo) && (segundo + terceiro > primeiro))
    {
        Console.WriteLine("Forma um triângulo!");


        if ((primeiro == segundo) && (segundo == terceiro))
        {
            Console.WriteLine("Triângulo Equilátero");
        }
        else if ((primeiro == segundo) || (primeiro == terceiro) || (segundo == terceiro))
        {
            Console.WriteLine("Triângulo Isósceles");
        }
        else if ((primeiro != segundo) && (primeiro != terceiro) && (segundo != terceiro))
        {
            Console.WriteLine("Triângulo Escaleno");
        }
    }

    else
    {
        Saida();

    }


}
catch
{
    Console.WriteLine("Digite um valor válido!");
}

void Saida()
{
    Console.WriteLine("Os valores digitados não forma um triângulo");
}


Console.ReadKey();
