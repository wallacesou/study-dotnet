// OPERADORES RELACIONAIS

int x = 10;
int y = 20;

Console.WriteLine($"{x} == {y}: {x == y}");
Console.WriteLine($"{x} > {y}: {x == y}");
Console.WriteLine($"{x} < {y}: {x == y}");
Console.WriteLine($"{x} >= {y}: {x == y}");
Console.WriteLine($"{x} <= {y}: {x == y}");
Console.WriteLine($"{x} != {y}: {x == y}");

// Comparando strings
string a = "Curso";
string b = "curso";
Console.WriteLine(a == b);

// Método de comparação Equals()
Console.WriteLine(a.Equals(b));

Console.ReadKey();
