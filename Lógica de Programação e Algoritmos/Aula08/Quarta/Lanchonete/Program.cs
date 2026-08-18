//Dicionario
//Declaração de variáveis
int codigo, quantidade;
char outropedido = ' ';

Dictionary<int, (string nome, double preco)> produtos = new Dictionary<int, (string nome, double preco)>
{
    {1,("Cachorro Quente", 4.50) },
    {2,("X-Salada", 4.50) },
    {3,("X-Bacon", 5.00) },
    {4,("Torrada Simples", 2.00) },
    {5, ("Refrigerante", 1.50) }
};


void ImprimirCardapio()
{
    Console.WriteLine("""
        
        
========================================
        
           CARDÁPIO DA LANCHONETE
========================================
CÓDIGO | ITEM             | PREÇO       
----------------------------------------
""");
    foreach (var item in produtos)
    {
        Console.WriteLine($"{item.Key}      | {item.Value.nome.PadRight(15, ' ')}  | {item.Value.preco:c}");
    }
}

async Task PreparandoPedido()
{
    Console.WriteLine("Processando pedido... (aguarde)");
    await Task.Delay(2000);
}

async Task EfetuarPedido()
{

    while (outropedido != 'N')
    {
        ImprimirCardapio();
        Console.Write("\nDigite o código do produto (ou 0 para sair): ");
        codigo = int.Parse(Console.ReadLine());
        if (codigo == 0)
        {
            break;
        }

        var produtoselecionado = produtos[codigo];

        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        await PreparandoPedido();

        var totalapagar = produtoselecionado.preco * quantidade;


        Console.WriteLine($"Item selecionado: {produtoselecionado.nome}");

        Console.WriteLine($"Total a pagar: R$ {totalapagar:f2}");

        Console.Write("Deseja fazer outro pedido? (S/N): ");
        outropedido = char.Parse(Console.ReadLine().ToUpper());
    }
}

try
{
    await EfetuarPedido();
}
catch
{
    Console.WriteLine("Código do produto inválido! Tente novamente.");
    await EfetuarPedido();
}
finally
{
    Console.WriteLine("Sessão de pedido encerrado pelo sistema.");

}
Console.ReadLine();
