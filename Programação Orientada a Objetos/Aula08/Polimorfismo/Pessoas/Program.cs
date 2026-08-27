//Declaração de variáveis
using Pessoas.Classes.Entidades;

int n;
List<Funcionario> listaFuncionario = new();

//Entrada de dados
Console.Write("Deseja registrar quantos funcionários? ");
n = int.Parse(Console.ReadLine());

//Processamento de dados
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Colaborador nº {i + 1}");
    Console.Write("O funcionário é terceirizado (s/n)? ");
    char escolha = char.Parse(Console.ReadLine().ToLower());
    Console.Write("Nome do funcionario: ");
    string nome = Console.ReadLine();
    Console.Write("Quantidade de horas trabalhadas: ");
    int horas = int.Parse(Console.ReadLine());
    Console.Write("Valor da hora do funcionário: ");
    double valor = double.Parse(Console.ReadLine());



    if (escolha == 's')
    {
        //Criar um funcionário terceirizado
        listaFuncionario.Add(new Terceiro(nome, horas, valor));//cria objetos da super classe, na hora de instanciar vc aponta para outra subclasse.

    }
    else
    {
        //Criar um funcionário
        listaFuncionario.Add(new Funcionario(nome, horas, valor));
    }
}
Console.WriteLine("Pagamentos: ");
foreach (var pessoa in listaFuncionario)
{
    Console.WriteLine($"Nome: {pessoa.NomeFuncionario} - Pagamento: {pessoa.Pagamento()}"); 
}
