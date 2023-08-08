// ENTRADA DE DADOS

// ReadLine()
Console.Write("Informe seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos.");

// Read()
Console.WriteLine("Digite algo:");
var ascii = Console.Read();
Console.WriteLine($"O valor ASCII do primeiro caractere é {ascii}");

// ReadKey()
Console.ReadKey(); // segura a continuação do programa
