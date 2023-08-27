// ARRAYS

// Exemplo 1 / Declarando um array de strings
string[] nomes1 = new string[5] { "Ana", "Bea", "Lian", "Bill", "Jin" };

// Exemplo 2 / Ocultando o tamanho do array
string[] nomes2 = new string[] { "Ana", "Bea", "Lian", "Bill", "Jin" };

// Exemplo 3 / Ocultando a instância
string[] nomes3 = { "Ana", "Bea", "Lian", "Bill", "Jin" };

// Exemplo 4 / Declarando e atribuindo valores pelos índices
int[] numeros = new int[3];
numeros[0] = 6;
numeros[1] = 7;
numeros[2] = 5;


// Acessando elementos de um array usando índices
Console.WriteLine("Acessando nome de uma array: " + nomes1[4]); // Jin

// Percorrendo elementos de um Array usando o laço for
for (int i = 0; i < numeros.Length; i++)
    Console.WriteLine($"Índice ({i}): Número: {numeros[i]}");

// Percorrendo elementos de um array usando o laço foreach
foreach (string nome in nomes1)
    Console.Write($"{nome} ");

Console.ReadKey();
