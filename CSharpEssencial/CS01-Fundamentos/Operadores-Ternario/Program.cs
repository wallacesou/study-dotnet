// OPERADOR TERNÁRIO

Console.Write("Informe a temperatura: ");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado = temp > 27 ? "quente" : "frio";
Console.WriteLine($"O tempo está {resultado}");

// Operador ternário aninhado
int x = 10, y = 20;
string msg = x > y ? "x é maior que y" :
                    x < y ? "x é menor que y" :
                    x == y ? "x é igual a y" : "sem resultado";

Console.WriteLine(msg);

Console.ReadKey();
