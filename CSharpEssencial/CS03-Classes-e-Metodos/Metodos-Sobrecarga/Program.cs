// SOBRECARGA DE MÉTODOS (OVERLOADS)

Calculadora calc = new Calculadora();

// Usando todas as sobrecargas do método
Console.WriteLine(calc.Somar(9, 2));
Console.WriteLine(calc.Somar(5, 1, 4));
Console.WriteLine(calc.Somar(3, 7.5));
Console.WriteLine(calc.Somar(6.3, 8));

Console.ReadKey();

// Criando uma classe com várias sobrecargas
class Calculadora
{
    public int Somar(int n1, int n2) // a assinatura deste método é única
    {
        return n1 + n2;
    }
    public int Somar(int n1, int n2, int n3) // diferencia pela quantidade de parâmetros
    {
        return n1 + n2 + n3;
    }
    public double Somar(int n1, double n2) // diferencia pelo tipos dos parâmetros
    {
        return n1 + n2;
    }
    public double Somar(double n1, int n2) // diferencia pela ordem dos tipos
    {
        return n1 + n2;
    }
}
