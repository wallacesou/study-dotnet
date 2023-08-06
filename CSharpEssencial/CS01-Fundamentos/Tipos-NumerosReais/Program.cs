// TIPOS DE DADOS: NÚMEROS DE PONTO FLUTUANTE

float n1 = 1.234F;
Console.WriteLine(n1);

double n2 = 1.234;
Console.WriteLine(n2);

decimal n3 = 1.234M;
Console.WriteLine(n3);

Console.WriteLine("\nComparando a precisão dos tipos:");

// os sufixos em inteiros são opcionais, mas neste exemplo precisamos incluir para dividir com precisão
float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine("float: " + x);
Console.WriteLine("double: " + y);
Console.WriteLine("decimal: " + z);

Console.ReadKey();
