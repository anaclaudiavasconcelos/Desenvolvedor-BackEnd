using Aplicativo_03;
//Declaração de variáveis
string nome;
double nota1, nota2, nota3;

Console.Write("Nome do aluno: ");
nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");
nota1 = double.Parse(Console.ReadLine());
nota2 = double.Parse(Console.ReadLine());
nota3 = double.Parse(Console.ReadLine());

Aluno objeto = new Aluno(nome, nota1, nota2, nota3);

Console.WriteLine($"Nota final do aluno: {}");