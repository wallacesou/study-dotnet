// HERANÇA: VIRTUAL E OVERRIDE

Aluno a = new();
a.Nome = "Miller";
a.Curso = "Programação";
Console.WriteLine(a.Apresentar());


Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public virtual string Apresentar() => $"Nome: {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public override string Apresentar() => $"{Nome}, do curso de {Curso}.";
}
