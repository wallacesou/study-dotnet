// // PASSAGEM DE ARGUMENTOS POR REFERÊNCIA - REF

int x = 20; // variável 'x' inicializada com o valor '20'
Console.WriteLine($"Valor de x: {x}");

Calculo calc = new Calculo(); // objeto criado

Console.WriteLine("Valor de y: " + calc.Dobrar(ref x)); // é passado a cópia da referência do argumento 'x' para 'y'

Console.WriteLine($"Valor de x: {x}"); // a variável 'x' agora é '40'

Console.ReadKey();

class Calculo
{
    public int Dobrar(ref int y)
    {
        return y *= 2; // aqui a instrução trabalha na mesma área da memória da variável 'x'
    }
}
