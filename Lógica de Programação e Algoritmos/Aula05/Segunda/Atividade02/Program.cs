//Declaração de var~iáveis

double a, b, c, calcPerimetro, calcTrapezio;

try
{
    //Entrada de dados
    Console.Write("Digite valor de A: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Digite valor de B: ");
    b = double.Parse(Console.ReadLine());
    Console.Write("Digite valor de C: ");
    c = double.Parse(Console.ReadLine());

    
    //Saída de dados

    if((a + b > c) && (a + c > b) && (b + c > a))
    {
        Perimetro();
        Console.WriteLine($"Perímetro = {calcPerimetro:f1}");
        
    }
    else
    {
        AreaTrapezio();
        Console.WriteLine($"Área = {calcTrapezio:f1}");
    }



}
 catch
{
    Console.WriteLine("Digite valores válidos");
}

double Perimetro()
{
    calcPerimetro = a + b + c;
    return calcPerimetro;
}

double AreaTrapezio()
{
    calcTrapezio = ((a + b) * c) / 2;
    return calcTrapezio;

}

Console.ReadKey();