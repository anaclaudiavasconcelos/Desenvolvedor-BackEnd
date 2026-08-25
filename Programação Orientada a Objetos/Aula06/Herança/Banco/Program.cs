
using Banco.Classes;
bool sair = true;
double saldo, quantia;
int numero;
string nome;
Conta conta1;
ContaPoupanca contaPoupanca;
ContaEmpresa contaEmpresa;

while (sair != false)
{
    Console.WriteLine("Selecione qual tipo de conta deseja abrir:\n" +
        "\t 1 - Conta Normal\n" +
       "\t 2 - Conta Poupança\n" +
       "\t 3 - Conta Empresa\n" +
       "\t 4 - Sair\n");
    int selecao = int.Parse(Console.ReadLine());
    switch (selecao)
    {
        case 1:
            Console.WriteLine("Selecionado conta normal");
            Opcao1();
            break;
        case 2:
            Console.WriteLine("Selecionado conta poupança");
            Opcao2();
            break;
        case 3:
            Console.WriteLine("Selecionado conta empresa");
            Opcao3();
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
    Console.Write("Entre com o número da conta: ");
    numero = int.Parse(Console.ReadLine());
    Console.Write("Entre com o nome do titular da conta: ");
    nome = Console.ReadLine();
    Console.Write("Deseja fazer deposito inicial? (s/n): ");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 's')
    {
        Console.Write("Qual o valor do depósito inicial? ");
        saldo = double.Parse(Console.ReadLine());
        conta1 = new Conta(nome, numero, saldo);

    }
    else
    {
        conta1 = new Conta(nome, numero);
    }

    Console.WriteLine(conta1.ToString());

    Console.Write("Entre com um valor para depósito: ");
    quantia = double.Parse(Console.ReadLine());
    conta1.Deposito(quantia);
    Console.Write("Entre com um valor para saque: ");
    quantia = double.Parse(Console.ReadLine());
    conta1.Saque(quantia);
    Console.WriteLine(conta1.ToString());

}

void Opcao2()
{
    Console.Write("Entre com o número da conta: ");
    numero = int.Parse(Console.ReadLine());
    Console.Write("Entre com o nome do titular da conta: ");
    nome = Console.ReadLine();
    Console.Write("Deseja fazer deposito inicial? (s/n): ");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 's')
    {
        Console.Write("Qual o valor do depósito inicial? ");
        saldo = double.Parse(Console.ReadLine());
        contaPoupanca = new ContaPoupanca(nome, numero, saldo, 0);

    }
    else
    {
        contaPoupanca = new ContaPoupanca(nome, numero, 0);
    }

    Console.WriteLine(contaPoupanca.ToString());


    Console.Write("Entre com um valor para depósito: ");
    quantia = double.Parse(Console.ReadLine());
    contaPoupanca.Deposito(quantia);
    Console.Write("Entre com um valor para saque: ");
    quantia = double.Parse(Console.ReadLine());
    contaPoupanca.Saque(quantia);
    Console.WriteLine(contaPoupanca.ToString());

}

void Opcao3()
{
    Console.Write("Entre com o número da conta: ");
    numero = int.Parse(Console.ReadLine());
    Console.Write("Entre com o nome do titular da conta: ");
    nome = Console.ReadLine();
    Console.Write("Deseja fazer deposito inicial? (s/n): ");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 's')
    {
        Console.Write("Qual o valor do depósito inicial? ");
        saldo = double.Parse(Console.ReadLine());
        contaEmpresa = new ContaEmpresa(nome, numero, saldo, 0);

    }
    else
    {
        contaEmpresa = new ContaEmpresa(nome, numero, 0);
    }

    Console.WriteLine(contaEmpresa.ToString());

    Console.Write("Entre com um valor para depósito: ");
    quantia = double.Parse(Console.ReadLine());
    contaEmpresa.Deposito(quantia);
    Console.Write("Entre com um valor para empréstimo: ");
    quantia = double.Parse(Console.ReadLine());
    contaEmpresa.Emprestimo(quantia);
    Console.WriteLine(contaEmpresa.ToString());

}


