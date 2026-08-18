//Declaração de variáveis
int valor1;
int valor2;
int valor3;
string pergunta1;
string pergunta2;
string pergunta3;
string pergunta4;
string informar1;
string informar2;
string informar3;


//Entrada de dados
Console.Write("Digite um valor: ");
valor1 = int.Parse(Console.ReadLine());

Console.Write("Digite um valor: ");
valor2 = int.Parse(Console.ReadLine());

Console.Write("Digite um valor: ");
valor3 = int.Parse(Console.ReadLine());

//Processamento de dados

pergunta1 = (valor1 == valor3 ? "Verdadeiro" : "Falso");
pergunta2 = (valor1 != valor2 ? "Verdadeiro" : "Falso");
pergunta3 = (valor2 > valor1 ? "Verdadeiro" : "Falso");
pergunta4 = (valor2 <= valor3 ? "Verdadeiro" : "Falso");

informar1 = (pergunta1 == "Verdadeiro" && pergunta3 == "Verdadeiro" ? "Verdadeiro" : "Falso");
informar2 = (pergunta2 == "Verdadeiro" || pergunta4 == "Verdadeiro" ? "Verdadeiro" : "Falso");
informar3 = (pergunta1 == "Falso" ? "Verdadeiro" : "Falso");


//Saída de dados


Console.WriteLine("O primeiro valor é igual ao terceiro valor? R:"  + (pergunta1));
Console.WriteLine("O primeiro valor é diferente do segundo valor? R: " + (pergunta2));
Console.WriteLine("O segundo valor é maior que o primeiro valor? R: " + (pergunta3));
Console.WriteLine("O segundo valor é menor ou igual que o terceiro valor? R: " + (pergunta4));

Console.WriteLine("Se a pergunta 1 e pergunta 3 são verdadeiros: " + (informar1));
Console.WriteLine("Se a pergunta 2 e pergunta 4 pelo menos uma é verdadeiro: " + (informar2));
Console.WriteLine("Se a negação da pergunta 1 é verdadeiros: " + (informar3));



Console.ReadKey();  