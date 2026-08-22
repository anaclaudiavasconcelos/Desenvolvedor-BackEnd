
using System.Runtime.InteropServices;
    bool sair = true;
while (sair != false)
{


    Console.WriteLine("Selecione qual tipo de conta deseja abrir:\n" + "\t 1 - Conta Normal\n" + "\t 2 - Conta Poupança\n" + "\t 3 - Conta Empresa\n" + "\t 4 - Sair\n");
    int selecao = int.Parse(Console.ReadLine());
    switch (selecao)
    {
    case 1:
        Console.WriteLine("Selecionado conta normal");
    break;
    case 2:
        Console.WriteLine("Selecionado conta poupança");
        break;
    case 3:
        Console.WriteLine("Selecionado conta empresa");
        break;
    case 4:
        sair = false;
        break;
    default:
        Console.WriteLine("Selecionado nenhuma opção, tente novamente!");
    break;

}
}

void Opcao1()
    {
    Console.WriteLine("Deseja fazer deposito inicial? (s/n) ");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 'n')
    {
        
    }
    else
    {
        Console.WriteLine("Qual o valor do depósito inicial? ");
    }

}





