// MÉTODOS COM PARÃMETROS

Mensagens msg = new Mensagens();
msg.AprensetarPessoa("Maria", 'F');

Console.ReadKey();

class Mensagens
{
    public void AprensetarPessoa(string nome, char genero)
    {
        Console.WriteLine("Olá {0}, seja bem vind{1} ao sistema!", nome, genero == 'F' ? "a" : "o");
    }
}
