// OPERADORES DE ATRIBUIÇÃO

Console.Write("Digite um número: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{x} + {y} ==> {x += y}");
Console.WriteLine($"{x} - {y} ==> {x -= y}");
Console.WriteLine($"{x} * {y} ==> {x *= y}");
Console.WriteLine($"{x} / {y} ==> {x /= y}");
Console.WriteLine($"{x} % {y} ==> {x %= y}");

// Operador de atribuição em strings
Console.WriteLine("\nConcatenação");
string str = "123";
str += "456";
Console.WriteLine(str);


// OPERADOR DE INCREMENTO E DECREMENTO

x = 10;

++x; // pré-incremento
x++; // pós-incremento

--x; // pré-decremento
x--; // pós-decremento


// Diferença entre pré e pós incremento/decremento
int a, resultado;

a = 0;
resultado = a++ + 10; // 10 -> primeiro calcula e depois incrementa
Console.WriteLine(resultado);

a = 0;
resultado = ++a + 10; // 11 -> primeiro incrementa e depois calcula
Console.WriteLine(resultado);


// ATRIBUIÇÃO DE VALORES EM CONSTANTES

const int MESES_ANO = 12; // aceita múltiplas declarações na mesma linha
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;
Console.WriteLine("A média de dias por mês no ano é: " + (int)DIAS_POR_MES);


Console.ReadKey();
