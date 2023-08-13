// INSTRUÇÃO WHILE

// Exemplo 1: o código será executado determinadas vezes

Console.Write("Digite um número: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i < 10)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
    i++;
}

// Exemplo 2: a condição de parada depende do usuário

while (true)
{
    Console.Write("Digite um número (999 para sair): ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n == 999)
        break;

    if (n % 2 == 0)
        Console.WriteLine($"O número {n} é par");
    else
        Console.WriteLine($"O número {n} é impar");
}

// Exemplo 3: um while dentro de um while (while aninhado)

int x = 0, y = 0;
while (x < 3)
{
    y = 0;
    while (y < 3)
        Console.Write($"({x},{y++}) ");
    Console.WriteLine();
    x++;
}

Console.ReadKey();
