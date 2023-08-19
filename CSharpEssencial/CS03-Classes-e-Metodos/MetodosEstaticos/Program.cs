// MÉTODOS ESTÁTICOS

Console.WriteLine("Somar 9 + 2: " + Calculadora.Somar(9, 2));
Console.WriteLine("Subtrair 8 - 5: " + Calculadora.Subtrair(8, 5));
Console.WriteLine("Multiplicar 5 * 3: " + Calculadora.Multiplicar(5, 3));
Console.WriteLine("Dividir 10 + 2: " + Calculadora.Dividir(10, 2));

Console.ReadKey();


class Calculadora
{
    // métodos estáticos
    public static int Somar(int n1, int n2) => n1 + n2;
    public static int Subtrair(int n1, int n2) => n1 - n2;
    public static double Multiplicar(double n1, double n2) => n1 * n2;
    public static double Dividir(double n1, double n2) => n1 / n2;
}
