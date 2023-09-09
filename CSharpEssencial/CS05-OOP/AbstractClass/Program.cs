Quadrado q = new();
q.Lado = 3.14;
q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"Área do quadrado: {q.Area} m2");
Console.WriteLine($"Perímetro do quadrado: {q.Perimetro}");

Console.WriteLine(q.Detalhes());

Console.ReadKey();


abstract class Forma
{
    // propriedades
    public double Area { get; set; }
    public double Perimetro { get; set; }

    // métodos abstratos
    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    // método padrão
    public string Detalhes()
    {
        return $"Executanto na classe \"{this}\" ";
    }
}

class Quadrado : Forma
{
    public double Lado { get; set; }
    public override void CalcularArea()
    {
        Area = Lado * Lado;
    }

    public override void CalcularPerimetro()
    {
        Perimetro = 4 * Lado;
    }
}
