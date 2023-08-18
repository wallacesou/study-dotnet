// ARGUMENTOS NOMEADOS

Email email = new Email();
email.Enviar(titulo: "Urgente", assunto: "Próxima reunião com os devs dia 15/05", destino: "email@email.com");
/* os argumentos acima não precisam
 * estar na mesma ordem dos
 * parâmetros declarados nos métodos
 * se usarmos argumentos nomeados
 */

Console.ReadKey();

class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Para: {destino,24}");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Assunto: {titulo.ToUpper()}");
        Console.WriteLine("------------------------------");
        Console.WriteLine(assunto);
    }
}
