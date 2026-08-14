//Calculadora
using Aplicativo01;

//Declaração de variáveis
double raio;

//Entrada de dados
Console.Write("Entre com o valor do raio da circunferência: ");
raio = double.Parse(Console.ReadLine());


//Processamento de dados

//Saída de dados
Console.WriteLine($"Circunferência: {Calculadora.Circunferencia(raio):f2}" + $"Volume: {Calculadora.Volume(raio):f2}");
Calculadora.PI();