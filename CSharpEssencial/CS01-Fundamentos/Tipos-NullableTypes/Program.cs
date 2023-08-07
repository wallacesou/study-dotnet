// TIPOS DE DADOS: NULLABLE TYPES

int? a = null; // basta colocar o operador '?' após o tipo

// int b = a; // (error) 'int' é diferente de 'int?'

int b = a ?? 0; // se 'a' for null, retorna 0

Console.WriteLine(b);

// Propriedade 'HasValue' e 'Value'
if (a.HasValue)
    Console.WriteLine(a.Value);
else
    Console.WriteLine("a não possui um valor (null)");

Console.ReadKey();
