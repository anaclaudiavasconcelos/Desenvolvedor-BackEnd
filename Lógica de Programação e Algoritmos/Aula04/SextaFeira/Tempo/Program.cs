//DateTime - representação de horas e datas
//TimeSpan

/*var horario = DateTime.Now;

 DateTime data1 = new(1991, 8, 27, 10, 10, 50); //formatar datas e horas desse jeito.*/

/*DateTime data1 = new(1991, 8, 27); //formatar datas e horas desse jeito.
DateTime data2 = new(1993, 6, 7);

/*var data = data1.AddDays(10); //adiciona 10 dias a data1
Console.WriteLine(data.Month);


var data = DateTime.Compare(data1, data2);

Console.WriteLine(data);

Console.WriteLine(horario);*/



//Declarando variáveis
int segundos, minutos, hora;

//Entrada de dados
Console.WriteLine("Digite a duração em segundos: ");
int totalsegundos = int.Parse(Console.ReadLine()); //totalsegundos foi declarado nessa linha.

//Processamento de dados
hora = totalsegundos / 3600; //3600 segundos = 1 hora
minutos = (totalsegundos % 3600) / 60; //3600 segundos = 1 hora, 60 segundos = 1 minuto
segundos = (totalsegundos % 3600) % 60; //3600 segundos = 1 hora, 60 segundos = 1 minuto

//Saída de dados
Console.WriteLine($"{hora}:{minutos}:{segundos}");