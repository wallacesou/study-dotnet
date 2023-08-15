// MÉTODOS COM PARÂMETROS: PASSANDO PARÂMETROS ENTRE CLASSES

Aluno aluno = new Aluno();
Console.Write("Nome: ");
aluno.Nome = Console.ReadLine();
Console.Write("Idade: ");
aluno.Idade = Convert.ToInt32(Console.ReadLine());
Console.Write("Gênero: ");
aluno.Genero = Console.ReadLine()?.ToUpper()[0];
Console.Write("Aprovado: ");
aluno.Aprovado = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine();

Curso curso = new Curso();
curso.Resultado(aluno);

Console.ReadKey();

class Aluno
{
    public string? Nome;
    public int Idade;
    public char? Genero;
    public bool Aprovado;
}

class Curso
{
    public void Resultado(Aluno a)
    {
        Console.WriteLine($"Aluno: {a.Nome}");
        Console.WriteLine($"Idadde: {a.Idade}");
        if (a.Genero == 'F')
            Console.WriteLine("Gênero: Feminino");
        else if (a.Genero == 'M')
            Console.WriteLine("Gênero: Masculino");
        if (a.Aprovado)
            Console.WriteLine("Aluno aprovado!");
        else
            Console.WriteLine("Aluno reprovado!");
    }
}
