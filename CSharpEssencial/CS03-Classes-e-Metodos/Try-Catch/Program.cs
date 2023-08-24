// TRY-CATCH

Console.Write("Digite um número: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite outro número: ");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"Resultado da divisão: {x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine($"\n\tErro: <<<{ex.Message}>>>\n");
    Console.WriteLine($"Detalhes do erro: {ex.StackTrace}");
}
finally
{
    Console.WriteLine("\nPrograma encerrado...");
}

Console.ReadKey();
