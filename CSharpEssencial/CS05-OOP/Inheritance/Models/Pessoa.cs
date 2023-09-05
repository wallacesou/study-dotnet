namespace Inheritance.Models;
internal class Pessoa // classe base
{
    public string? Nome { get; set; }
    public char Genero { get; set; }
    
    public void Apresentar()
    {
        Console.WriteLine($"{this}: {Nome}");
    }
}
