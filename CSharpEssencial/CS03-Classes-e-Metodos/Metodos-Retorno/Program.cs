// MÉTODOS COM RETORNO

Calculadora calc = new();

var valor = calc.Somar(2, 2); // guardando o valor retornado do método

Console.WriteLine(valor);

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public double Multiplicar(double n1, double n2)
    {
        return n1 * n2;
    }
    public double Dividir(double n1, double n2)
    {
        return n1 / n2;
    }
}
