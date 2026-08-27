using Master.Classes.Entidades;
using Master.Enumeracoes;

//Conta contaCesar = new Conta("Cesar", 123456, 1000); // pega a super classe e aponta para aonde quiser. Polimorfismo, pega a super classe e aponta para subclasse através de instanciar
//Conta contaClodoaldo = new ContaPoupanca("Clodoaldo", 123456, 10);// polimorfismo, pega a super classe e aponta para subclasse através de instanciar
//Conta senai = new ContaEmpresa("Mange", 123456, 1000);// polimorfismo, pega a super classe e aponta para subclasse através de instanciar

//Declaração de variáveis
Conta conta;
string titular;
int numero;
double saldo, limite, taxa;


//Entrada de dados
Console.Write("Selecione as opções abaixo: " +
            "\n 1 - Conta Pessoa Física" +
            "\n 2 - Conta Poupança" +
            "\n 3 - Conta Empresa" +
             "\nDeseja abrir qual tipo de conta:");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Normal}");
        AbrirConta();
        break;
    case 2:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Poupança}");
        AbrirPoupanca();
        break;
    case 3: 
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Empresa}");
        AbrirEmpresa();
        break;
    default:
        Console.WriteLine("Nenhuma Opção selecionada");
        conta = null;
        break;
}

Console.WriteLine();
conta.ExibirDados();

void AbrirConta()
{
    Console.Write("Qual é o titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Número da conta: {numero} ");
    Console.Write("Deseja fazer depósito inicial (s/n)?: ");
    char opcion = char.Parse(Console.ReadLine().ToLower());

    if (opcion == 's')
    {
        Console.Write("Qual o valor do depósito inicial? ");
        saldo = double.Parse(Console.ReadLine());
        conta = new Conta(titular, numero, saldo);
    }
    else
    {
        conta = new Conta(titular, numero);
    }
}

    void AbrirPoupanca()
{
    Console.Write("Qual é o titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Número da conta: {numero} ");
    Console.Write("Taxa da conta: ");
    taxa = double.Parse(Console.ReadLine());
    Console.Write("Deseja fazer depósito inicial (s/n)?: ");
    char opcion = char.Parse(Console.ReadLine().ToLower());

    if (opcion == 's')
    {
        Console.Write("Qual o valor do depósito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new ContaPoupanca(titular, numero, saldo, taxa);
    }
    else
    {
        conta = new ContaPoupanca(titular, numero, taxa);
    }
}

void AbrirEmpresa()
{
    Console.Write("Qual é o titular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Número da conta: {numero} ");
    Console.Write("Limite da conta: ");
    limite = double.Parse(Console.ReadLine());
    Console.Write("Deseja fazer depósito inicial (s/n)?: ");
    char opcion = char.Parse(Console.ReadLine().ToLower());

    if (opcion == 's')
    {
        Console.Write("Qual o valor do depósito inicial? ");
        saldo = double.Parse(Console.ReadLine());
        conta = new ContaEmpresa(titular, numero, saldo, limite);
    }
    else
    {
        conta = new ContaEmpresa(titular, numero, limite);
    }
}


