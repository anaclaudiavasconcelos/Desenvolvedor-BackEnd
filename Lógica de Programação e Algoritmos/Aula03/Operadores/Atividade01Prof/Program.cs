//Declaração de variáveis

int numero1;
int numero2;
int numero3;
bool pergunta1;
bool pergunta2;
bool pergunta3;
bool pergunta4;
bool logica1;
bool logica2;
bool logica3;


//Entrada de dados
Console.Write("Digite o primeiro valor: ");
numero1 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
numero2 = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: ");
numero3 = int.Parse(Console.ReadLine());

//Processamento de dados

pergunta1 = (numero1 == numero3);
pergunta2 = (numero1 != numero2);
pergunta3 = (numero2 > numero1);
pergunta4 = (numero2 <= numero3);

logica1 = pergunta1 & pergunta3;
logica2 = pergunta2 | pergunta4;
logica3 = !pergunta1;
    
    //Saída de dados

Console.WriteLine("--Comparações--");
Console.WriteLine($"O 1º valor é igual ao 3º valor? R: {(pergunta1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O 1º valor é igual ao 2º valor? R:  { (pergunta2 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O 2º valor é maior que 1ºvalor? R:  { (pergunta3 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O 2º valor é menor ou igual que o 3º valor? R: { (pergunta4 ? "Verdadeiro" : "Falso")}");

Console.WriteLine("--Lógica--");
Console.WriteLine($"Se a pergunta1 e pergunta3 são verdadeiras. R {(logica1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"Se a pergunta2 e pergunta4 pelo menos uma é verdadeira. R {(logica2 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"Se a negação da primeira pergunta é verdadeira. R {(logica3 ? "Verdadeiro" : "Falso")}");
