// CLASSE ARRAY

string[] nomes = { "Jin", "Zelda", "Bea", "Lian", "Bill", "Ana", "Maria", "James" };

// Array original
Console.Write("Original: ");
ExibirArray(nomes);

// Invertendo a ordem do array
Console.Write("Reverse: ");
Array.Reverse(nomes);
ExibirArray(nomes);

// Ordenando array
Console.Write("Sort: ");
Array.Sort(nomes);
ExibirArray(nomes);

// Localizando um item no array
Console.Write("Digite um nome pra ver se está no array: ");
string? nome = Console.ReadLine();
var indice = Array.BinarySearch(nomes, nome);

Console.WriteLine(indice >= 0 ? $"Achamos \"{nomes[indice]}\" na posição {indice}" : "Esse nome não foi encontrado!");

Console.ReadKey();

static void ExibirArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($"{nome}, ");
    }
    Console.WriteLine("\n");
}
