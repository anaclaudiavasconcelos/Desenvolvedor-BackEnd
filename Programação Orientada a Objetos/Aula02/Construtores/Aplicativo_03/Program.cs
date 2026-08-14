
using Aplicativo_03;
//Declaração de variáveis
string nome;
double nota1, nota2, nota3;

//Entrada de dados
Console.Write("Nome do aluno: ");
nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");

double RetornaNota(int i)
{
    double nota;

    do
    {
        Console.Write($"Digite a nota{i}: ");
        nota = double.Parse(Console.ReadLine());
        if (nota < 0 || nota > 100)
        {
            Console.WriteLine("Nota inválida, valores permitidos de 0 a 100!");
        }
    } while (nota < 0 || nota > 100);

    return nota;
}

nota1 = RetornaNota(1);
nota2 = RetornaNota(2);
nota3 = RetornaNota(3);


Aluno objeto = new Aluno(nome, nota1, nota2, nota3);

Console.WriteLine($"Nota final do aluno: {objeto.NotaFinal()}");

if (objeto.AprovadoOuReprovado())
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine($"Reprovado, faltou {objeto.Ponto()} pontos");
}

Console.ReadKey();
