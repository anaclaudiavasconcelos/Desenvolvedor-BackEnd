//Lista
//Declaração de variáveis
List<int> numeros = new List<int>();

int n, valor;

try
{
    //Entrada de dados
    Console.Write("Quantos números você vai digitar? ");
    n = int.Parse(Console.ReadLine());

    //Loop determinado
    for (int i = 0; i < n; i++) //para armazenar os dados. Percorre a lista e gravar os valores digitados pelo usuário
    {

        Console.Write("Digite um número: ");
        valor = int.Parse(Console.ReadLine());
        numeros.Add(valor);
        
    }

    Console.WriteLine("Números negativos: ");
    foreach (var item in numeros) //para percorrer a lista
    {

        if(item < 0)
        {
            Console.WriteLine(item);
        }
        
    }


}
catch (Exception e)
{

    Console.WriteLine("Valor inválido, erro:" + e); ;
}

Console.ReadKey();

