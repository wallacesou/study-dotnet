// INSTRUÇÃO SWITCH

// Exemplo 1

Console.Write("Digite o valor do produto: R$");
double valor = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o número de parcelas: ");
int parcelas = Convert.ToInt32(Console.ReadLine());

switch (parcelas)
{
    case 1:
        Console.WriteLine($"O pagamento será de 1 x {valor:C}");
        break;
    case 2:
        Console.WriteLine($"O pagamento será de 2 x {(valor + valor * 0.022) / 2:C}");
        break;
    case 3:
        Console.WriteLine($"O pagamento será de 3 x {(valor + valor * 0.023) / 3:C}");
        break;
    case 4:
        Console.WriteLine($"O pagamento será de 4 x {(valor + valor * 0.024) / 4:C}");
        break;
    case 5:
        Console.WriteLine($"O pagamento será de 5 x {(valor + valor * 0.025) / 5:C}");
        break;
    case 6:
        Console.WriteLine($"O pagamento será de 6 x {(valor + valor * 0.026) / 6:C}");
        break;
    default: Console.WriteLine("Valor de parcelas inválido!"); break;
}

// Exemplo 2

Console.Write("\nDigite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0: Console.WriteLine($"{numero} é PAR!"); break;
    case 1: Console.WriteLine($"{numero} é IMPAR!"); break;
}

// Exemplo 3

Console.Write("\nDigite o mês: ");
var mes = Console.ReadLine()?.ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "setembro":
    case "novembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}

Console.ReadKey();
