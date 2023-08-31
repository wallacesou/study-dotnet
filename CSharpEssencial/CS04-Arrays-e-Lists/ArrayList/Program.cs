// ARRAYLIST

using System.Collections;

// Exemplos de como criar ArrayLists
ArrayList lista1 = new ArrayList(); // #1

ArrayList lista2;
lista2 = new ArrayList(); // #2

ArrayList list3 = new(); // #3

var list4 = new ArrayList(); // #4


// Atribuindo valores no momento da inicialização
var lista = new ArrayList() { "Jim", "Mozart", 19, true };

// Propriedades de ArrayList
Console.WriteLine(lista.Count); // retorna o número de elementos dentro da lista
Console.WriteLine(lista.Capacity); // retorna a capacidade atual da lista

// Métodos para manipular elementos na lista
lista.Add(4.5); // acrescenta o elemento ao final da lista
lista.Insert(2, "Silver"); // acrescenta o elemento na posição especificada

lista.Remove("Mozart"); // remove a primeira ocorrência de um objeto especificado
lista.RemoveAt(4); // remove elemento no índice especificado
lista.RemoveRange(2, 2); // remove um número definido de elementos a partir de um índice especificado

var verifica = lista.Contains("Jim"); // verifica se elemento contém o item especificado, retorna 'true' ou 'false'
Console.WriteLine($"\"Jim\" está na lista? {verifica}");

ArrayList nomes = new ArrayList() { "Jim", "Zen", "Bea", "Ana", "Kai", "Teo" };
nomes.Sort(); // ordena a ArrayList com elementos do mesmo tipo na ordem ascendente

foreach (var n in nomes)
    Console.Write($"{n}, ");

nomes.Clear(); // remove todos os elementos de uma ArrayList sem alterar sua capacidade

// Métodos para adicionar arrays na lista
double[] array = { 8.5, 7, 10, 9 };

lista.AddRange(array); // acrescenta array ao final da lista
lista.InsertRange(2, array); // acrescenta array na posição especificada

Console.ReadKey();
