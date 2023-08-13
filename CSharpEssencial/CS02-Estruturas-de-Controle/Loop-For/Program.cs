// INSTRUÇÃO FOR

// Exemplo 1

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}

// Exemplo 2

Console.WriteLine("\nTabuada usando for");
Console.Write("Digite um número: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < 10; i++)
    Console.WriteLine($"{num} x {i} = {num * i}");

// Exemplo 3

Console.WriteLine("\nMatriz usando for");
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
        Console.Write($"({x},{y}) ");
    Console.WriteLine();
}

// Exemplo 4

Console.WriteLine("\nMúltiplas instruções usando for");
for (int i = 0, j = 0; i + j <= 10; i++, j++)
    Console.WriteLine($"[i = {i} | j = {j}]");

// Exemplo 5

Console.WriteLine("\nUsando for sem nenhuma instrução");
int a = 0;
for (; ; )
{
    Console.WriteLine(a++);
    if (a == 5)
        break;
}

Console.ReadKey();
