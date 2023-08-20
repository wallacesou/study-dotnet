// PROPRIEDADES

Produto p1 = new();
p1.Nome = "Caderno";
p1.Preco = 15.00;
p1.Desconto = 5;
p1.Unidades = 2;

p1.Comprar();


Console.ReadKey();

class Produto
{
    // campos de apoio
    private string? nome;
    private double desconto;
    private int estoque = 95;

    // propriedades
    public string? Nome
    {
        get { return nome?.ToUpper(); }
        set { nome = value; }
    }
    public double Preco { get; set; }
    public double Desconto
    {
        get { return desconto; }
        set { desconto = Preco - Preco * (value / 100); }
    }
    public int Estoque { get { return estoque; } } // somente leitura
    public int Unidades { set { estoque -= value; } } // somente gravação

    public void Comprar()
    {
        Console.WriteLine("Compra Realizada!");
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: {Preco:C}");
        Console.WriteLine($"Preço com desconto: {Desconto:C}");
        Console.WriteLine($"Estoque: {Estoque}");
    }
}
