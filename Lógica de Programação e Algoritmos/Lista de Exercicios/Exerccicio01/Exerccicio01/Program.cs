//Declaracão de variáveis
char turno;


try
    {
    //Entrada de dados
    Console.Write("Em que turno você estuda?\n M - Matutino\n V - Vespertino\n N - Noturno\n Favor digitar o caracter correspondente:");
    turno = char.Parse(Console.ReadLine());



    if (turno == 'M')
    {
        Console.Write("Bom Dia!");
    }
    else if (turno == 'V')
    {
        Console.Write("Boa Tarde!");
    }
    else if (turno == 'N')
            {
        Console.Write("Boa Noite!");
            
            }
    else
    {
        Saida();    ;
            
    }

}

    catch{

    Console.WriteLine("Valor inválido!");
}

void Saida()
{
    Console.WriteLine("Digite um caracter válido!");
   
}


Console.ReadKey();
