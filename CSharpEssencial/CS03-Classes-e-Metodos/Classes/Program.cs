// CLASSES

// Criando um objeto do tipo 'Pessoa'
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Maria";
pessoa.Idade = 25;
pessoa.Genero = 'F';

// Exibindo dados do objeto 'pessoa'
Console.WriteLine($"Nome: {pessoa.Nome}");
Console.WriteLine($"Idade: {pessoa.Idade}");
Console.WriteLine($"Gênero: {pessoa.Genero}");

Console.ReadKey();


// Criando a classe 'Pessoa'
class Pessoa
{
    public string? Nome;
    public int Idade;
    public char Genero;
}
