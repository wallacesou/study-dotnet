// INSTRUÇÃO BREAK E CONTINUE

int i = 2;
while (true)
{
    Console.WriteLine($"Quantidade de cartas: [{i}]");
    Console.Write("Quer continuar? [sim/parar/pular]: ");
    var option = Console.ReadLine()?.ToLower();
    if (option == "parar")
        break;
    if (option == "pular")
        continue;
    i += 3;
    Console.WriteLine($"\tVocê agora tem mais {i} cartas");
}

Console.ReadKey();
