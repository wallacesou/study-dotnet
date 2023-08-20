// CONSTRUTOR ESTÁTICO

// criando objetos que possuem um construtor estático, que será executado primeiro e só uma vez
Candidato c1 = new("Mario", 29);
Candidato c2 = new("Maria", 25);
Candidato c3 = new("Gregory", 16);

Console.ReadKey();

class Candidato
{
    public string? Nome;
    public int Idade;
    public static int IdadeMinima;
    public Candidato(string nome, int idade)
    {
        Console.WriteLine("\nExecutando construtor parâmetrizado");
        Nome = nome;
        Idade = idade;
        Console.WriteLine($" Candidato: {Nome}, {Idade} anos");
        Console.WriteLine($" Idade mínima: {IdadeMinima}");
        Console.WriteLine($" Candidato aprovado: {Idade >= IdadeMinima}\n");
    }
    static Candidato() // sem modificadores de acesso e sem parâmetros
    {
        Console.WriteLine("\nExecutando construtor estático");
        IdadeMinima = 18;
    }
}
