//Declaração de variável
const int senha = 2002;


//Entrada de dados
Console.Write("Digite a senha: ");
int n = int.Parse(Console.ReadLine());

while(senha != n)
{
    
    Console.Write("Senha incorreta, tente novamente: ");
    n = int.Parse(Console.ReadLine());
    
    
}
Console.WriteLine("Acesso permitido!");