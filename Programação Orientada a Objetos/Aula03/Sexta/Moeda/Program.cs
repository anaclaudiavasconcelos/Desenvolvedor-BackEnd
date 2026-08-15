using Moeda;


//Declaração de variáveis
double cotacao, compra;

//Entrada de dados
Console.Write("Qual é a cotação do dolar? ");
cotacao = double.Parse(Console.ReadLine());
Console.Write("Quantos dólares você vai comprar? ");
compra = double.Parse(Console.ReadLine());

Console.Write($"Valor a ser pago em reias = {ConversorDeMoeda.Pagamento(cotacao, compra):f2}");

Console.ReadKey();
