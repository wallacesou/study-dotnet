// INSTRUÇÃO IF

Console.Write("Digite um número: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine($"{x} é maior que {y}");
}
if (x < y)
{
    Console.WriteLine($"{x} é menor que {y}");
}
if (x == y)
{
    Console.WriteLine($"{x} é igual à {y}");
}

Console.ReadKey();
