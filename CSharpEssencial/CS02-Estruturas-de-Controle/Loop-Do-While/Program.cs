// INSTRUÇÃO DO-WHILE

// Exemplo 1
int i = 1;

do
{
    Console.WriteLine(i++);
}
while (i <= 10);

// Exemplo 2
int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y}) ");
    } while (++y < 3);
    Console.WriteLine();
} while (++x < 3);

Console.ReadKey();
