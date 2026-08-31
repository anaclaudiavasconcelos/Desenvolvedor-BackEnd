using ZAbstracao.Classes.Entidades;
using ZAbstracao.Classes.Servicos;
using ZAbstracao.Enumeracao;
using ZAbstracao.Interfaces;

//Declaracão de variàveis
string nome;
double renda, gastos;
double arrecadacaoPessoaFisica = 0;
double arrecadacaoPessoaJuridica = 0;
int numerofuncionario;


List<PessoaFisica> listaPessoasFisica = new();
List<PessoaJuridica> listaPessoasJuridica = new();


Console.Write("Quantos contribuintes quer digitar? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    Console.Write("Digite 1 para Pessoa Física ou 2 para Pessoa Jurídica: ");
    int contribuinte = int.Parse(Console.ReadLine());
    Console.Write("Digite o nome: ");
    nome = Console.ReadLine();
    Console.Write("Digite a renda anual: ");
    renda = double.Parse(Console.ReadLine());




    if (contribuinte == 1)
    {
        Console.Write("Teve gastos com saúde? Se sim digite o valor ou digite 0: ");
        gastos = double.Parse(Console.ReadLine());
        listaPessoasFisica.Add(new PessoaFisica(nome, renda, (Contribuinte)contribuinte, gastos));
        Console.WriteLine();

    }


    if (contribuinte == 2)
    {
        Console.Write("Quantos funcionários possui? ");
        numerofuncionario = int.Parse(Console.ReadLine());
        listaPessoasJuridica.Add(new PessoaJuridica(nome, renda, (Contribuinte)contribuinte, numerofuncionario));
        Console.WriteLine();
    }

}
IAssinatura imposto = new Imposto();

foreach (var pessoa in listaPessoasFisica)
{
    double impostoPessoaFisica = imposto.CalcularImposto(pessoa);
    arrecadacaoPessoaFisica += impostoPessoaFisica;
    Console.Write($"Nome: {pessoa.Nome}\n" + $"Imposto: {impostoPessoaFisica:c}\n");

}

Console.WriteLine();

foreach (var pessoa in listaPessoasJuridica)
{
    double impostoPessoaJuridica = imposto.CalcularImposto(pessoa);
    arrecadacaoPessoaJuridica += impostoPessoaJuridica;
    Console.Write($"Nome: {pessoa.Nome}\n" + $"Imposto: {impostoPessoaJuridica:c}\n");
}

Console.WriteLine();

Console.WriteLine($"Impostos arrecadados da pessoa fisica: {arrecadacaoPessoaFisica:c}");

Console.WriteLine($"Impostos arrecadados da pessoa jurídica: {arrecadacaoPessoaJuridica:c}");

Console.WriteLine($"Total de imposto arrecadado: {arrecadacaoPessoaFisica + arrecadacaoPessoaJuridica:c}");

Console.ReadKey();