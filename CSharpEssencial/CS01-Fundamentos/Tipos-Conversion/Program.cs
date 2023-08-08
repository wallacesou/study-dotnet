// CONVERSÃO DE TIPOS

int a;
double b;

// Conversão Implícita
a = 100; // int usa 4 bits
b = a; // double usa 8 bits
Console.WriteLine(b);

// Conversão Explícita
b = 12.2938;
a = (int)b;
Console.WriteLine(a);

int num1 = 10;
int num2 = 4;
float result1 = num1 / num2; // 2
float result2 = (float) num1 / num2; // 2.5
Console.WriteLine(result1);
Console.WriteLine(result2);

// Método ToString()
string c = b.ToString();
Console.WriteLine(c);

// Métodos da classe Convert
Console.WriteLine(Convert.ToInt32(b));
Console.WriteLine(Convert.ToDecimal(c));
Console.WriteLine(Convert.ToBoolean(a)); // se for diferente de 0 sempre vai ser true

Console.ReadKey();
