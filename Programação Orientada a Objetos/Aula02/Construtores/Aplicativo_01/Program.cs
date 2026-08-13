using Aplicativo_01;
//Declaração de variáveis
double larg;
double alt;

//Entrada de dados 
Console.WriteLine("Entre a largura e depois a altura do retângulo:");
larg = double.Parse(Console.ReadLine());
alt = double.Parse(Console.ReadLine());
     
Retangulo objeto = new Retangulo(larg, alt);

Console.Write($"Valores digitados foram\n\n Largura = {larg:f2}\n Altura = {alt:f2}\n\n");

Console.WriteLine($"A área do retângulo é de {objeto.Area():f2}");
Console.WriteLine($"O perímetro do retângulo é de {objeto.Perimetro():f2}");
Console.WriteLine($"A diagonal do retângulo é de {objeto.Diagonal():f2}");

Console.ReadKey();
    