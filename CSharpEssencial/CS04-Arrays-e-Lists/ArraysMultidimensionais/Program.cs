// ARRAYS BIDIMENSIONAIS
int[,] a = new int[2, 2]; // exemplo 1

a[0, 0] = 1;
a[0, 1] = 2;
a[1, 0] = 3;
a[1, 1] = 4;

Console.WriteLine($"[ {a[0, 0]}, {a[0, 1]} ]");
Console.WriteLine($"[ {a[1, 0]}, {a[1, 1]} ]");

// ACESSANDO ARRAYS COM LAÇO FOR
int[,] b = { { 3, 5 }, { 4, 6 } }; // exemplo 2

// laço for
for (int x = 0; x < b.GetLength(0); x++) // primeira dimensão
{
    for (int y = 0; y < b.GetLength(1); y++) // segunda dimensão
    {
        Console.Write($"{ b[x, y]} ");
    }
}
Console.WriteLine();

// laço foreach
foreach (var n in b)
{
    Console.Write($"{n} ");
}

Console.ReadKey();
