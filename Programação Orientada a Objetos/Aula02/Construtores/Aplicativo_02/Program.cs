using Aplicativo_02;
//Declaraçao de variáveis
string nome;
double salarioBruto;
double imposto;
double porcentagem;

//Entrada de dados
Console.Write("Digite o nome do funcionário: ");
nome = Console.ReadLine();
Console.Write("Digite o salário bruto do funcionário: ");
salarioBruto = double.Parse(Console.ReadLine());
Console.Write("Digite o valor total de imposto a ser pago pelo funcionário: ");
imposto = double.Parse(Console.ReadLine());

Funcionario objeto = new Funcionario(nome, salarioBruto, imposto);

Console.WriteLine($"Dados do funcionário\n Nome do funcionário: {nome}\n Salário líquido: R$ {objeto.SalarioLiquido():c}\n");

Console.Write("Digite a porcentagem de aumento do salário do funcionário: ");
porcentagem = double.Parse(Console.ReadLine());

Console.WriteLine($"Salário do funcionário aumentado em {porcentagem:f2}%\n");

objeto.AumentarSalario(porcentagem);

Console.WriteLine($"Dados do funcionário atualizados\n Nome do funcionário: {nome}\n Salário líquido: R$ {objeto.SalarioLiquido():c}");

Console.ReadKey();




     
