//Declaração de variáveis
using System.Diagnostics.Tracing;

int numero;
string dia = "";

try
{
    //Entrada de dados
    Console.Write("Digite um número de 1 a 7:");
    numero = int.Parse(Console.ReadLine());

    if (numero == 1)
    {
        dia = "Domingo";
        Console.WriteLine($"O dia correspondente é: {numero}-{dia}");
    }
    else if (numero == 2)
    {
        dia = "Segunda";
        Console.WriteLine($"O dia correspondente é: {numero}-{dia}");

    }
    else if (numero == 3)
    {
        dia = "Terça";
        Console.WriteLine($"O dia correspondente é: {numero}-{dia}");
    }
    else if (numero == 4)
    {
        dia = "Quarta";
        Console.WriteLine($"O dia correspondente é: {numero}-{dia}");
    }
    else if (numero == 5)
    {
        dia = "Quinta";
        Console.WriteLine($"O dia correspondente é: {numero}-{dia}");
    }
    else if (numero == 6)
    {
        dia = "Sexta";
        Console.WriteLine($"O dia correspondente é: {numero}-{dia}");
    }
    else if (numero == 7)
    {
        dia = "Sábado";
        Console.WriteLine($"O dia correspondente é: {numero}-{dia}");
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
    Console.WriteLine("Valor Inválido");
}

Console.ReadKey();
