using Banco.Classes.Contextos;
using Banco.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

ContaContext contexto = new ContaContext();

//contexto.Database.EnsureCreated();

bool continuar = true;
while (continuar)
{
    Console.WriteLine("--Menu Principal--" +
        "\n 1 - Cadastrar nova conta" +
        "\n 2 - Consultar conta existente" +
        "\n 3 - Sair");

    Console.Write("\nEscolha uma opção: ");
    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            //Cadastrar conta
            CadastrarConta(contexto);
            break;
        case "2":
            //Consultar uma conta
            ConsultaConta(contexto);
            break;
        case "3":
            continuar = false;
            Console.WriteLine("Encerrando sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void CadastrarConta(ContaContext conta)
{
    Console.WriteLine("=== Cadastro de conta ===\n");
    Console.Write("Digite o número da conta: ");
    int numero = int.Parse(Console.ReadLine());
    Console.Write("Digite o titular da conta: ");
    string titular = Console.ReadLine();
    Console.Write("Terá deposito inicial (s/n) ?");
    char escolha = char.Parse(Console.ReadLine().ToLower());

    var numeroContaExistente = conta.contas.FirstOrDefault(c => c.NumeroDaConta == numero);
    if(numeroContaExistente != null)
    {
        Console.WriteLine($"\nErro: Já existe uma conta com o número {numero}");
        return;
    }

    Conta contaCriada;

    if(escolha.Equals('s'))
    {
        Console.Write("Qual o valor do depósito inicial: ");
        decimal deposito = decimal.Parse(Console.ReadLine());
        contaCriada = new Conta(numero, titular, deposito);
    }
    else
    {
        contaCriada = new Conta(numero, titular, 0);
    }

    conta.contas.Add(contaCriada); //Create - Criar
    conta.SaveChanges();
    Console.WriteLine("\nConta cadastrada com sucesso!");
    contaCriada.ExibirDados();
}

void ConsultaConta(ContaContext conta)
{
    Console.WriteLine("=== Consulta de conta ===");
    Console.Write("Digite o número da conta: ");
    int numero = int.Parse(Console.ReadLine());
    var contaConsultada = conta.contas.FirstOrDefault(c => c.NumeroDaConta == numero);
    if(contaConsultada == null)
    {
        Console.WriteLine($"\nConta {numero} não encontrada!");
        return;
    }

    contaConsultada.ExibirDados(); //Read

    continuar = true;
    while (continuar)
    {
        Console.WriteLine(" -- Operações -- ");
        Console.WriteLine(" 1 - Depositar ");
        Console.WriteLine(" 2 - Sacar ");
        Console.WriteLine(" 3 - Alterar titular da conta");
        Console.WriteLine(" 4 - Voltar ao menu principal");
        Console.Write("\nEscolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1:
                //Operacão Depósito
                Console.Write("Digite o valorpara depósito");
                decimal valor = decimal.Parse(Console.ReadLine());
                contaConsultada.Depositar(valor);
                conta.SaveChanges();
                contaConsultada.ExibirDados();
                break;
             case 2:
                //Operação de sacar
                Console.WriteLine("Digite o valor para sacar: ");
                valor = decimal.Parse(Console.ReadLine());
                contaConsultada.Sacar(valor);
                conta.SaveChanges();
                 break;
             case 3:
                //Operação alterar o titular da conta
                break;
             case 4:
                //Sair
                continuar = false;
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}