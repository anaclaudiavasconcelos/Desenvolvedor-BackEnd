//Coleção de dados
//tamanho definido.
/* -- Array -- */

/*int[] numeros = {0, 1, 2, 10, 4 };
string[] names = { "Clodoaldo", "Kelvin", "Cesa" };
char[] caracteres; //criou mais não colocou o tamanho

Console.WriteLine(numeros.Length);// usa para percorrer todo o array.

Console.WriteLine(numeros[3]);

numeros[3] = 56;

Console.WriteLine(numeros[3]);

caracteres = new char[10]; //criou o array com tamanho 10*/


/* -- Dicionario -- */ //não acessa por indice , acessa por um valor chave
                       //tamanho dinâmico.
                       //chave é uma palavra e os dados que serão guradados é um double
/*Dictionary<string, double> salarios = new Dictionary<string, double>()
{
   {"Alice", 1.73 }, //são chaves únicas, não pode repetir
   {"Bob", 62.9 },
   {"Clodoaldo", 14 }

};

Console.WriteLine(salarios["Bob"]);
salarios.Add("SENAI", 8.96); //adiciona um elemento no dicionario
Console.WriteLine(salarios["SENAI"]);
salarios.Remove("Alice"); //remove o elemento do dicionario

foreach (var item in salarios)//percorre o dicionario
{
    Console.WriteLine(item.Key + " tem " + item.Value);//item.Key pega a chave e item.Value pega o valor
}

if(salarios.ContainsKey("Bob"))//verifica se existe a chave no dicionario
{
    Console.WriteLine("Bob esta na coleção");
}*/


/* -- Lista -- */ //tamanho dinâmico

/*List<int> lista1 = new List<int>();//instaciar, criar na memória
lista1.Add(5600);
lista1.Add(600);
lista1.Add(0);
lista1.Add(50);

foreach (var item in lista1)
{
    Console.WriteLine(item);
}
lista1.Insert(2, 900);//acessou o indice 2,que é 0 e guardou o valor 900.
lista1.Remove(600);

foreach (var item in lista1)
{
    Console.WriteLine(item);
}

lista1.Clear();//limpa a lista

foreach (var item in lista1)
{
    Console.WriteLine(item);
}*/

/* -- Tuplas --*/ // permiti valores dinâmicos. tamanho fixo. 

var pessoa = ("Cesar", 34, 2.5, 'M');
Console.WriteLine(pessoa.Item1);//nome
Console.WriteLine(pessoa.Item2);//idade
Console.WriteLine(pessoa.Item3);//salario
Console.WriteLine(pessoa.Item4);//gênero

pessoa.Item1 = "Clodoaldo";//permite trocar o valor.

Console.WriteLine(pessoa.Item1); //nome
Console.WriteLine(pessoa.Item2);//idade
Console.WriteLine(pessoa.Item3);//salario
Console.WriteLine(pessoa.Item4);//gênero

var pessoa2 = (Nome: "Cesar", Idade: 35);//nomeando os elementos da tupla, no lugar de Item1, Item2, etc, podemos usar nomes mais descritivos.

