// USANDO ARRAYS COMO PARÂMETROS

int[] valores = { 1, 2, 3 };
Console.WriteLine(Calcula1.Somar(valores));
// ou
Console.WriteLine(Calcula1.Somar(new int[] { 7, 3, 2, 6, 1, 8 }));
// ou
Console.WriteLine(Calcula2.Somar(1, 2, 3, 4, 6, 7, 8, 9)); // com 'params' é possível passar os valores diretamente no método separados por vírgula


Console.ReadKey();

// Exemplo 1
class Calcula1
{
    public static int Somar(int[] numeros)
    {
        return numeros.Sum();
    }
}

// Exemplo 2
class Calcula2
{
    public static int Somar(params int[] numeros)
    {
        return numeros.Sum();
    }
}
