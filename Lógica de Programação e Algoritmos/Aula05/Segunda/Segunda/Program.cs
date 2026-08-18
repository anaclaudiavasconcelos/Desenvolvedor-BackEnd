const string JANELA = "Problema medidas";
Console.Title = JANELA;

//Declaração de variáveis
double a, b, c, quadrado, triangulo, trapezio; // variável global

//Entrada de dados
Console.Write("Digite a medida A: ");
a = double.Parse(Console.ReadLine());
Console.Write("Digite a medida B: ");
b = double.Parse(Console.ReadLine());
Console.Write("Digite a medida C: ");
c = double.Parse(Console.ReadLine());

//Processamento de dados
AreaQuadrado();
AreaTriangulo();
AreaTrapezio();

//Saída de dados
Saida();

Console.ReadKey();

double AreaQuadrado()// Nome de função cria com a 1ª letra em maiúsculo
{
    /*string nome = "SENAI"; //variável local ela não existe para o restante do código, ela é criada dentro da função.*/
    quadrado = a * a;
    return quadrado;
}

double AreaTriangulo()
{
    triangulo = (a * b) / 2;
    return triangulo;
}

double AreaTrapezio()
{
    trapezio = ((a + b) * c) / 2;
    return trapezio;
    }

void Saida()
{
    Console.WriteLine($"A area do quadrado = {quadrado:f4}\n" + $"A area do triangulo = {triangulo:f4}\n" + $"A area do trapézio é {trapezio:f4}");
}