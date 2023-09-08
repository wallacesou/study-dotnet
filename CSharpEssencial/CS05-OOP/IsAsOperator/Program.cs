// OPERADOR AS

object a = "Mozart";

string? b = a as string; // não lança exceção

Console.WriteLine(b != null ? b : "null");


// OPERADOR IS

if (a is string)
    Console.WriteLine("A conversão é possível!");

Console.ReadKey();
