// OBJETOS: Formas de criar um objeto

// * exemplo 1
Pessoa p1 = new Pessoa();
p1.Nome = "Markus";
p1.Idade = 31;
p1.Genero = 'M';

Console.WriteLine($"{p1.Nome}, {p1.Idade} anos. Gênero: {p1.Genero}");

// * exemplo 2
var p2 = new Pessoa();
p2.Nome = "Connor";
p2.Idade = 27;
p2.Genero = 'M';

Console.WriteLine($"{p2.Nome}, {p2.Idade} anos. Gênero: {p2.Genero}");

// * exemplo 3 (disponível a partir do C# na versão 10)
Pessoa p3 = new();
p3.Nome = "Kara";
p3.Idade = 28;
p3.Genero = 'F';

Console.WriteLine($"{p3.Nome}, {p3.Idade}, anos. Gênero: {p3.Genero}");


Console.ReadKey();

class Pessoa
{
    public string? Nome;
    public int Idade;
    public char Genero;
}
