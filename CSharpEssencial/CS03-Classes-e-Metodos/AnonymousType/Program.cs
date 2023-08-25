// TIPOS ANÔNIMOS

// Exemplo 1: um tipo anônimo básico
var cliente = new
{
    Nome = "Maria",
    Idade = 25
};

Console.WriteLine($"Nome: {cliente.Nome} | Idade: {cliente.Idade}");

// Exemplo 2: um tipo anônimo dentro de um tipo anônimo
var aluno = new
{
    Id = 1,
    Nome = "Matt",
    Email = "matt@email.com",
    Endereco = new { Id = 1, Cidade = "Londres", Pais = "Reino Unido" }
};

Console.WriteLine($"{aluno.Nome} mora em {aluno.Endereco.Cidade}");

// Exemplo 3: um tipo anônimo de array
var alunos = new[]
{
    new { Id = 1, Nome = "Maria", Email = "maria@email.com" },
    new { Id = 2, Nome = "Martin", Email = "martin@email.com" },
    new { Id = 3, Nome = "Julian", Email = "julian@email.com" }
};

Console.WriteLine($"Aluno: {alunos[2].Nome} | E-mail: {alunos[2].Email}");


Console.ReadKey();
