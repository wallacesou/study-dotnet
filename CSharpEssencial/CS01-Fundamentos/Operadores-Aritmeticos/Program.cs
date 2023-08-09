// OPERADORES ARITMÉTICOS

Console.Write("Digite um número: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Soma de {x} + {y} = {x + y}");
Console.WriteLine($"Subtração de {x} - {y} = {x - y}");
Console.WriteLine($"Multiplicação de {x} * {y} = {x * y}");
Console.WriteLine($"Divisão de {x} / {y} = {x / y}");
Console.WriteLine($"Módulo de {x} % {y} = {x % y}");

// CLASSE MATH

Console.WriteLine("\n---> Classe Math <---");
Console.WriteLine($"Raíz quadrada de {x} = {Math.Sqrt(x)}");
Console.WriteLine($"Potência de {x} elevado a {y} = {Math.Pow(x, y)}");
Console.WriteLine($"Valor máximo entre {x} e {y} = {Math.Max(x, y)}");
Console.WriteLine($"Valor mínimo entre {x} e {y} = {Math.Min(x, y)}");
Console.WriteLine($"Seno de {x} = {Math.Sin(x)}");
Console.WriteLine($"Cosseno de {x} = {Math.Cos(x)}");
Console.WriteLine($"Tangente de {x} = {Math.Tan(x)}");
Console.WriteLine($"Exponencial de {x} = {Math.Exp(x)}");

Console.ReadKey();
