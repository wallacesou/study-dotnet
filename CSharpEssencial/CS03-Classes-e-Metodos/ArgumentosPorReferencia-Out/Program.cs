// PASSAGEM DE ARGUMENTOS POR REFERÊNCIA - OUT

Console.Write("Digite o RAIO do círculo: ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();
/* 
double area = circulo.Area(raio);
double perimetro = circulo.Perimetro(raio);
    // Antes eu precisava criar essas duas variáveis //
*/

double perimetro = circulo.AreaPerimetro(raio, out double area); // 'out' torna possível que a variável 'area' seja criada com o valor recebido do método a partir desse ponto

Console.WriteLine($"Area: {area}"); // agora eu posso usar a variável 'area'
Console.WriteLine($"Perímetro: {perimetro}");

Console.ReadKey();

class Circulo
{
    public double Area(double raio)
    {
        return Math.PI * Math.Pow(raio, 2);
    }
    public double Perimetro(double raio)
    {
        return 2 * Math.PI * raio;
    }
    public double AreaPerimetro(double raio, out double areaCalculada)
    {
        areaCalculada = Math.PI * Math.Pow(raio, 2);
        return 2 * Math.PI * raio;
    }
}
