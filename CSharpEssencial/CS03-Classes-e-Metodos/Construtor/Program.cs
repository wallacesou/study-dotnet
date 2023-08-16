// CONSTRUTOR

Curso curso = new Curso();
// um construtor padrão é iniciado, definindo todos os membros da instância com valores padrão

Aluno aluno = new Aluno("Maria", 25, 'F', true);
// quando definimos um construtor na classe, o construtor padrão não é criado

Console.WriteLine($"Nome: {aluno.Nome}");
Console.WriteLine($"Idade: {aluno.Idade}");
Console.WriteLine("Gênero: {0}", aluno.Genero == 'F' ? "Feminino" : "Masculino");
Console.WriteLine("Pravas: {0}", aluno.Provas ? "Aprovado" : "Reprovado");

Console.ReadKey();


// Class sem construtor
class Curso
{
    public Aluno? Aluno;
    public string? Cursar;
}

// Classe com construtor
class Aluno
{
    public Aluno()
    {

    }
    public Aluno(string nome) => Nome = nome; // construtor usando body expression
    public Aluno(string nome, int idade) : this(nome)
    {
        Idade = idade;
    }
    public Aluno(string nome, int idade, char genero, bool provas) : this(nome, idade)
    {
        Genero = genero;
        Provas = provas;
    }

    public string? Nome;
    public int Idade;
    public char Genero;
    public bool Provas;
}
