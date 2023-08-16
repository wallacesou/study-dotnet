// THIS

// * exemplo 1
var cliente = new Cliente("Wallace", 23);
cliente.Apresentar();

Console.WriteLine();

// * exemplo 2
Aluno aluno = new();
aluno.Nome = "Matt";
aluno.Idade = 26;
aluno.Aprensentar();

Console.WriteLine();

// exemplo 3
Somar s = new(5);


Console.ReadKey();

// Exemplo 1
class Cliente
{
    private string nome;
    private int idade;

    public Cliente(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void Apresentar() =>
        Console.WriteLine($"Cliente: {nome}\nIdade: {idade}");
}

// Exemplo 2
class Aluno
{
    public string? Nome;
    public int Idade;

    public void ExibirInfo(Aluno aluno)
    {
        Console.WriteLine($"{this}: {aluno.Nome}"); // 'this' aqui vai mostrar o nome desta classe (this class)
        Console.WriteLine($"Idade: {aluno.Idade}");
    }

    public void Aprensentar()
    {
        ExibirInfo(this); // 'this' aqui vai passar os valores desta classe para o método
    }
}

// Exemplo 3
class Somar
{
    public Somar(int n1, int n2)
    {
        Console.WriteLine($"Somando: {n1} + {n2} = {n1 + n2}");
    }

    public Somar(int n) : this(2, 2) // primeiro executa o construtor com dois parâmetros inteiros e depois volta e executa o seu próprio construtor
    {
        Console.WriteLine($"Fiz uma continha pra você visto que só me passou o número {n} :)");
    }
}
