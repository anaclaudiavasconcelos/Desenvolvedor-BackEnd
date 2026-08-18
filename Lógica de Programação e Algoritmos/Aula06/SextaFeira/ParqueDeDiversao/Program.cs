//Declaração de variáveis
int contagem = 0;
try
{
    Console.Write("Digite a quantidade de visitantes: ");
    int nvisitantes = int.Parse(Console.ReadLine());
    Console.Write("Digite a altura mínima permitida (em cm): ");
    double altura_minima = double.Parse(Console.ReadLine());
    Console.Write("Digitea altura máxima permitida (em cm): ");
    double altura_maxima = double.Parse(Console.ReadLine());

    for(int i = 1; i<=nvisitantes; i++)
    {
        Console.Write($"Digite a altura do visitante número {i} (em cm):");
        double alturadigitada = double.Parse(Console.ReadLine());

       if( alturadigitada >= altura_minima & alturadigitada <= altura_maxima)
        {
            contagem++;
        }
    }

    Console.WriteLine($"Total de pessoas que podem entrar na montanha-russa: {contagem} ");
        
}
catch
{
    Console.WriteLine("Valor inválido. Digite um número inteiro.");
}

Console.ReadLine();