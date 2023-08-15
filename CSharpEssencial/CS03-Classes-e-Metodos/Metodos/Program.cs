// MÉTODOS

Pessoa pessoa = new Pessoa();
pessoa.Andar();
pessoa.Correr();
pessoa.Pular();
pessoa.AcaoAndar();

Console.ReadKey();

class Pessoa
{
    // métodos
    public void Andar()
    {
        Console.WriteLine("andando");
    }
    public void Correr()
    {
        Console.WriteLine("correndo");
    }
    public void Pular()
    {
        Console.WriteLine("pulando");
    }

    // um método pode chamar outro método
    public void AcaoAndar()
    {
        Console.Write("A pessoa está ");
        Andar();
    }
}
