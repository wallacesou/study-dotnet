// LIST

// Instanciando listas
List<string> lista1 = new(); // #1

var lista2 = new List<int>(); // #2

// Atribuindo valores no momento da inicialização
var lista = new List<double>() { 9, 6.7, 1, 7 };

// Modificando valores em uma lista
lista[1] = 5;

// Exibindo valores de uma lista
foreach (var n in lista)
    Console.Write($"{n}, ");
Console.WriteLine();


// LIST: PROPRIEDADES
Console.WriteLine(lista.Count); // 4 : retorna o número de elementos dentro da lista
Console.WriteLine(lista.Capacity); // 4 : retorna a capacidade atual da lista


// LIST: MÉTODOS
lista.Add(4.5); // acrescenta o elemento ao final da lista
lista.Insert(2, 7); // acrescenta o elemento na posição especificada

lista.Remove(19); // remove a primeira ocorrência de um objeto especificado
lista.RemoveAt(4); // remove elemento no índice especificado
lista.RemoveRange(0, 2); // remove um número definido de elementos a partir de um índice especificado

lista.Contains(4.5); // verifica se a lista contém o item especificado, retorna true ou false

lista.Sort(); // ordena a lista com elementos do mesmo tipo na ordem ascendente
lista.Sort(); // ordena a lista com elementos do mesmo tipo na ordem ascendente

// Métodos para adicionar arrays na lista
double[] array = { 8.5, 7, 10, 9 };

lista.AddRange(array); // acrescenta array ao final da lista
lista.InsertRange(2, array); // acrescenta array na posição especificada

// Exibindo valores de uma lista
foreach (var n in lista)
    Console.Write($"{n}, ");
Console.WriteLine();


// LIST: MÉTODOS FINDS
List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

Console.WriteLine(frutas.Find(ProcuraPrimeiroR)); // Pera
Console.WriteLine(frutas.Find(IniciaComA)); // Abacate

// ou (expressão lambda)

string? primeiraFrutaComA = frutas.Find(f => f.Contains('a')); // Uva
string? ultimaFrutaComA = frutas.FindLast(f => f.Contains('a')); // Morango
int indexDaPrimeiraFrutaComE = frutas.FindIndex(f => f.Contains('e')); // 2
int indexDaUltimaFrutaComE = frutas.FindLastIndex(f => f.Contains('e')); // 4
var listaDeFrutasComE = frutas.FindAll(f => f.Contains('e')); // Pera, Abacate

Console.WriteLine(primeiraFrutaComA);
Console.WriteLine(ultimaFrutaComA);
Console.WriteLine(indexDaPrimeiraFrutaComE);
Console.WriteLine(indexDaUltimaFrutaComE);
foreach(var item in listaDeFrutasComE)
    Console.Write($"{item}, ");

Console.ReadKey();


// PREDICATE: MÉTODOS COM UM ÚNICO ARGUMENTO QUE RETORNAM UM VALOR BOOLEANO
static bool ProcuraPrimeiroR(string item) => item.Contains("r");
static bool IniciaComA(string item) => item.StartsWith("A");
