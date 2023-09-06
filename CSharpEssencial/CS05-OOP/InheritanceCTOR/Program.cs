// HERANÇA: CONSTRUTOR

Aluno a1 = new("Miller");
Aluno a2 = new();

Console.ReadKey();

class Pessoa
{
    protected Pessoa() // construtor vazio
    {
        Console.WriteLine("<empty>");
    }

    protected Pessoa(string nome)
    {
        Console.WriteLine($"Nome: {nome}");
    }
}

class Aluno : Pessoa
{
    // o construtor vazio do base é invocado automaticamente
    public Aluno()
    {
        // depois o código aqui é executado
    }

    // o construtor com um parametro string do base é invocado
    public Aluno(string nome) : base(nome)
    {
        // depois o código aqui é executado
    }
}
