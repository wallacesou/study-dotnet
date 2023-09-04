// INDEXADORES

Nomes n = new();
n[0] = "Robin";
n[1] = "Jake";
n[4] = "Miller";

Console.WriteLine($"--{n}--"); // Nomes
Console.WriteLine(n[0]); // Robin
Console.WriteLine(n[1]); // Jake
Console.WriteLine(n[2]); // ""
Console.WriteLine(n[3]); // ""
Console.WriteLine(n[4]); // Miller
Console.WriteLine(n[5]); // ""


Console.ReadKey();

class Nomes
{
    string[] nomes = new string[10];

    public string this[int i]
    {
        get // => i >= 0 && i < nomes.Length ? nomes[i] : string.Empty;
        {
            if (i >= 0 && i < nomes.Length)
                return nomes[i];
            return "";
        }
        set
        {
            if (i >= 0 && i < nomes.Length)
                nomes[i] = value;
        }
    }
}
