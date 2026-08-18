//declaração de variáveis
string entrada = "";
int qtdadeturistaveiculo;
int veiculoentrando = 0;
int turista = 0;


try
{

    while (entrada != "sair")
    {
       
        Console.WriteLine("Digite veículo entrando, voltando ou sair para encerrar o expediente: ");
        entrada = Console.ReadLine();
        if(entrada == "sair")
        {
            break;
        }
        Console.WriteLine("Quantos turistas tem no veículo? ");
        qtdadeturistaveiculo = int.Parse(Console.ReadLine());
        if (entrada == "entrando")
        {
            veiculoentrando++;
        }
        else if (entrada == "voltando")
        {
            veiculoentrando--;
        }

        if (qtdadeturistaveiculo > 0 || qtdadeturistaveiculo <= 4)
        {
            if (entrada == "entrando")
            {
                turista += qtdadeturistaveiculo;
            }
            else if (entrada == "voltando")
            {
                turista -= qtdadeturistaveiculo;
            }

        }

        Console.WriteLine($"Quantos turista tem no parque: {turista}");
        Console.WriteLine($"Quantos carros tem no parque: {veiculoentrando}");


    }
    Console.WriteLine("Expediente encerrado");


}
catch (Exception erro)
{

    Console.WriteLine($"Valor inválido, erro{erro}"); ;
}

Console.ReadKey();