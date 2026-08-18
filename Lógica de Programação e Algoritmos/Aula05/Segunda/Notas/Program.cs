//Declaração de variàveis
using System.ComponentModel.Design;

double nota1, nota2, notafinal;

try
{
    //Entrada de dados
    Console.Write("Digite a 1ª nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Digite a 2ª nota: ");
    nota2 = double.Parse(Console.ReadLine());

    //Processamento de dados
    Nota();

    //Saída de dados
    Console.WriteLine($"Nota final = {notafinal:f1}");
    if (notafinal > 60 & notafinal < 70 | notafinal == 100) 
    {
        Console.WriteLine("Recupeação");
    }
    else if(notafinal == 80)
    {
        Console.WriteLine("Parabés pela nota");
    }
    else
    {
        Console.WriteLine("Aprovado");
    }

}

catch
{
    Console.WriteLine("Digite valores vàlidos");
}

double Nota()
{
    notafinal = nota1 + nota2;
    return notafinal;
}