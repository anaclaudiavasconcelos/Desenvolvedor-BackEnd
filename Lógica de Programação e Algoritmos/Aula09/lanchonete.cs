//Dicionario
//Declaração de variáveis
using System.Runtime.CompilerServices;

int codigo, quantidade, preco;
char outropedido;

Dictionary<int,(string nome,double preco)> produtos = new Dictionary<int,(string nome,double preco)>()
{
     { 1, ("Cachorro Quente", 4.00) },
     { 2, ("X-Salada", 4.50) },
     { 3, ("X-Bacon", 5.00) },
     { 4, ("Torrada Simples", 2.00) },
     { 5, ("Refrigerante", 1.50) }

};

 void ExibirCardapio()
 {
Console.WriteLine(""" 
========================================
           CARDÁPIO DA LANCHONETE       
========================================
CÓDIGO | ITEM            | PREÇO       
----------------------------------------
  1    | Cachorro Quente | R$ 4,50     
  2    | X-Salada        | R$ 4,50     
  3    | X-Bacon         | R$ 5,00     
  4    | Torrada Simples | R$ 2,00     
  5    | Refrigerante    | R$ 1,50     
========================================

""");

preco = produtos.Values* produtos
foreach (var item in produtos)
{
    System.Console.WriteLine($"Item Selecionado:{item.Key}");
    System.Console.WriteLine($"Total a pagar: R${}");
        }
}

 


try
{

    while(codigo != 0 & outropedido != 'N')
    {
   
System.Console.WriteLine("Digite o código do produto (ou 0 para sair): ");
codigo = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite a quantidade desejada: ");
quantidade = int.Parse(Console.ReadLine());

System.Console.WriteLine("Pedido anotado");

async Task Principal()
        {
            System.Console.WriteLine("Processando pedido... (aguarde)");
            await Task.Delay(2000);
            
        }

//Processamento de dados




}
 System.Console.WriteLine("Deseja realizar outro pedido? S/N");
 outropedido = char.Parse(Console.ReadLine());



}
 catch
{
    System.Console.WriteLine("[ERRO]: Código do produto inválido! Tente novamente.");
}

finally
{
    System.Console.WriteLine("Operação concluída.");
}

Console.ReadKey();




