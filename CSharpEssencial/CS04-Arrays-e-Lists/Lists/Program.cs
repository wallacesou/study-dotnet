// LIST

// Exemplos de como criar Lists
List<int> lista1 = new List<int>(); // #1

List<int> lista2;
lista2 = new List<int>(); // #2

List<int> list3 = new(); // #3

var list4 = new List<int>(); // #4


// Atribuindo valores no momento da inicialização
var lista = new List<double>() { 19, 6.7, 19, 2 };

// Propriedades de List
Console.WriteLine(lista.Count); // retorna o número de elementos dentro da lista
Console.WriteLine(lista.Capacity); // retorna a capacidade atual da lista

// Métodos para manipular elementos na lista
lista.Add(4.5); // acrescenta o elemento ao final da lista
lista.Insert(2, 7); // acrescenta o elemento na posição especificada

lista.Remove(19); // remove a primeira ocorrência de um objeto especificado
lista.RemoveAt(4); // remove elemento no índice especificado
lista.RemoveRange(0, 2); // remove um número definido de elementos a partir de um índice especificado

var verifica = lista.Contains(4.5); // verifica se elemento contém o item especificado, retorna true ou false
Console.WriteLine($"\"Jim\" está na lista? {verifica}");

List<string> nomes = new List<string>() { "Jim", "Zen", "Bea", "Ana", "Kai", "Teo" };
nomes.Sort(); // ordena a lista com elementos do mesmo tipo na ordem ascendente

foreach (var n in nomes)
    Console.Write($"{n}, ");

nomes.Clear(); // remove todos os elementos de um List sem alterar sua capacidade

// Métodos para adicionar arrays na lista
double[] array = { 8.5, 7, 10, 9 };

lista.AddRange(array); // acrescenta array ao final da lista
lista.InsertRange(2, array); // acrescenta array na posição especificada

Console.WriteLine();

// LIST - MÉTODOS FIND
List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

Console.WriteLine(frutas.Find(ProcuraR)); // Pera
Console.WriteLine(frutas.Find(IniciaComA)); // Abacate

// ou (expressão lambda)

var find = frutas.Find(f => f.Contains("L")); // Laranja
var findLast = frutas.FindLast(f => f.Contains("a")); // Morango
var findIndex = frutas.FindIndex(f => f.Contains("e")); // 2
var findLastIndex = frutas.FindLastIndex(f => f.Contains("e")); // 4
var findAll = frutas.FindAll(f => f.Contains("e")); // Pera, Abacate

Console.WriteLine(find);
Console.WriteLine(findLast);
Console.WriteLine(findIndex);
Console.WriteLine(findLastIndex);
foreach(var item in findAll)
    Console.Write($"{item}, ");

Console.ReadKey();

static bool ProcuraR(string item) => item.Contains("r");
static bool IniciaComA(string item) => item.StartsWith("A");
