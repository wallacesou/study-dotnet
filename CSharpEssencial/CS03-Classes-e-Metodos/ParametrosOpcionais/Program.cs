// PARÂMETROS OPCIONAIS

Email email = new Email();
email.Enviar("dev1@email.com");
email.Enviar("dev2@email.com", assunto: "Alguns projetos estão pendentes...");
/* os argumentos acima usam
 * os valores opcionais dos parâmetros
 * caso os argumentos não sejam informados.
 * Podemos até omitir um argumento
 * no meio da lista de parâmetros se
 * usarmos argumentos nomeados.
 */

Console.ReadKey();

class Email
{
    public void Enviar(string destino, string titulo = "Relatório semanal", string assunto = "Segue em anexo o resumo dos seus projetos...")
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Para: {destino,24}");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Assunto: {titulo.ToUpper()}");
        Console.WriteLine("------------------------------");
        Console.WriteLine(assunto);
    }
}
