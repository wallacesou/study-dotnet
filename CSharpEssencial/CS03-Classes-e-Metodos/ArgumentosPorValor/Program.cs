// PASSAGEM DE ARGUMENTOS POR VALOR

int x = 20; // variável 'x' inicializada com o valor '20'
Console.WriteLine($"Valor de x: {x}");

Calculo calc = new Calculo(); // objeto criado

Console.WriteLine("Valor de y: " + calc.Dobrar(x)); // é passado uma cópia como argumento para 'y'

Console.WriteLine($"Valor de x: {x}"); // a variável 'x' continua com o valor '20'

Console.ReadKey();

class Calculo
{
    public int Dobrar(int y)
    {
        return y *= 2;
    }
}
