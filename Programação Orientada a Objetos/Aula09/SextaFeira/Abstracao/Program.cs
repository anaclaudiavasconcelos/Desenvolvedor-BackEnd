using Abstracao.Classes.Entidades;
using Abstracao.Enumeracoes;

List<Forma> formas = new(); //instaciação da lista

Console.Write("Quantas formas geometricas quer digitar? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Dados da forma # " + (i+1));
    Console.Write("Retângulo ou Círculo (R/C): ");
    char escolha = char.Parse(Console.ReadLine().ToUpper());
    Console.Write("Qual a cor do objeto? " + "--1 - Vermelho, 2 - Azul, 3- Amarelo --");
    int cor = int.Parse(Console.ReadLine());

    if (escolha.Equals('R')) //É a mesma coisa que escolha == 'R'
    {
        Console.Write("Digite a largura do retângulo? ");
        double largura = double.Parse(Console.ReadLine());
        Console.Write("Digite a altura do retângulo? ");
        double altura = double.Parse(Console.ReadLine());
        formas.Add(new Retangulo((Cor)cor, largura,altura));
    }
    else if (escolha.Equals('C'))
    {
        Console.WriteLine("Digite o raio do círculo? ");
        double raio = double.Parse(Console.ReadLine());
        formas.Add(new Circulo((Cor)cor, raio));

    }
    else
    {
        Console.WriteLine("Objeto selecionado não esta na lista!");
    }
}

Console.WriteLine("Lista de formas digitadas e suas area: ");

foreach (var figurinhas in formas)
{
    Console.Write($"{figurinhas.ToString()} - Cor: {figurinhas.Cor()} - Area da figura: ");
    figurinhas.Area();
}