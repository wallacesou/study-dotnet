// HERANÇA

using Inheritance.Models;

Aluno a = new()
{
    Nome = "Izuku Midoriya",
    Genero = 'M',
    Sala = "1A",
    Ano = 1,
    Ativo = true
};
a.Apresentar();

Professor p = new()
{
    Nome = "Toshinori Yagi",
    Genero = 'M',
    Materia = "Programação",
    Salario = 6245.97m
};
p.Apresentar();

Console.ReadKey();
