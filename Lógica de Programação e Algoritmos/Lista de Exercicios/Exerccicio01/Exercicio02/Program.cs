//Declaração de variáveis
double salario, percentual, reajuste;

try
{
    //Entrada de dados
    Console.Write("Digite o valor do seu salário:");
    salario = double.Parse(Console.ReadLine());


    
    if(salario <= 280)
    {
        percentual = 20;

        reajuste = salario * (percentual / 100);
    }
    else if((salario > 280) && (salario <= 700))
    {
        percentual = 15;
        reajuste = salario * (percentual / 100);
    }
    else if((salario > 700) && (salario < 1500))
    {
        percentual = 10;
        reajuste = salario * (percentual / 100);
    }
    else
    {
        percentual = 5;
        reajuste = salario * (percentual / 100);
    }


    //Saída de dados
    Console.WriteLine($"O salário antes do reajuste: R$ {salario:f2}");
    Console.WriteLine($"Percentual de aumento aplicado: {percentual} %");
    Console.WriteLine($"O valor do aumento é: R$ {reajuste:f2}");
    Console.WriteLine($"O novo salário após o aumento é: R$ {NovoSalario():f2} ");


}


catch
{
    Console.WriteLine("Valor inválido");
}

double NovoSalario()
{
    salario = salario + reajuste;
    return salario;
    
}

Console.ReadKey();
