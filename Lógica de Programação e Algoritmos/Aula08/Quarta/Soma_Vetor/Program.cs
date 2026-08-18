// Array
//Declaração de variáveis

double[] numeros;
double valores, soma, media;
int n;

try
{
    //Entrada de dados
    Console.Write("Quantos números você vai digitar? ");
    n = int.Parse(Console.ReadLine());//vai definir o tamanho do array e do loop
    numeros = new double[n];//criou o array com tamanho n

    for (int i = 0; i < n; i++)
    {
        Console.Write("Digite um número: ");
        numeros[i] = double.Parse(Console.ReadLine());
    }

    Console.Write("Valores =");
    foreach (var item in numeros)
    {
        Console.Write($" {item} ");
    }

    media = numeros.Average();//calcula a média dos valores do array
    soma = numeros.Sum();//calcula a soma dos valores do array

    Console.WriteLine($"\nSoma = {soma}" + $"\nMédia = {media:f2}");



}
catch (Exception e)
{

    Console.WriteLine($"Valor inválido, erro: {e}");
}
