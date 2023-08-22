// ENUMERATIONS

// Exibindo enum e seu valor
Console.Write(DiasDaSemana.Terça); // Terça
Console.Write(" - ");
Console.WriteLine((byte)DiasDaSemana.Terça); // 0

// Exibindo enum através de um número
Console.Write("Escolha o dia da semana: ");
int dia = Convert.ToInt32(Console.ReadLine());
var diaEmEnum = (DiasDaSemana)dia;
Console.WriteLine($"Você selecionou {diaEmEnum}");


Console.ReadKey();


// Criando um enumerador com um tipo personalizado (somente numérico inteiro)
enum DiasDaSemana : byte
{
    Domingo,
    Segunda,
    Terça,
    Quarta,
    Quinta,
    Sexta,
    Sábado,
}

// Atribuindo personalizados valores aos membros
enum Categorias
{
    Moda = 1,
    Automotivo = 5,
    Artes = 6,
    Bebidas = 10,
    Livros = 12,
    Brinquedos = 15
}
