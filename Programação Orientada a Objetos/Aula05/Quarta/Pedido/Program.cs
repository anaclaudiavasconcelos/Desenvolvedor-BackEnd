using Pedido.Classes.Entidades;
using Pedido.Classes.Enumeracoes;

/*Console.WriteLine(StatusPedidos.Pagamento_Pendente);
Console.WriteLine((StatusPedidos)2); //trás o faturado*/

Funcionario dev = new Funcionario("Clodoaldo");
Funcionario gerente = new Funcionario("Elma");

Empresa SENAI = new Empresa("João Baptista Salles");
Empresa Suzano = new Empresa("Suzano");

Suzano.AdicionarFuncionario(gerente);
Suzano.AdicionarFuncionario(dev);
Console.WriteLine(Suzano);

Suzano = null;//empresa deixou de existir, porém o funcionário continua a existir

Console.WriteLine(Suzano);
Console.WriteLine(dev);
