// STRUCTS

// Criando duas classes e duas structs
Classe classe1 = new(), classe2 = new();
Struct struct1 = new(), struct2 = new();

// Atribuindo valores na primeira classe e na primeira struct
classe1.x = 8;
classe1.y = 9;

struct1.x = 8;
struct1.y = 9;

classe2 = classe1; // agora as duas classes apontam para o mesmo local de memória na heap
// alterando a 'classe2', a modificação é refletida nas duas classes
classe2.x = 1;
classe2.y = 2;

struct2 = struct1; // agora a 'struct2' possui uma cópia dos valores da 'struct1' na stack
// alterando a 'struct2', a modificação não altera em nada a 'struct1'
struct2.x = 1;
struct2.y = 2;


Console.WriteLine($"Classe 1 => x = {classe1.x}, y = {classe1.y}" + " : classe 1 modificada");
Console.WriteLine($"Classe 2 => x = {classe2.x}, y = {classe2.y}");
Console.WriteLine();
Console.WriteLine($"Struct 1 => x = {struct1.x}, y = {struct1.y}" + " : struct 1 inalterada");
Console.WriteLine($"Struct 2 => x = {struct2.x}, y = {struct2.y}");

Console.ReadKey();


// Diferença de Struct e Classe
class Classe
{
    public int x { get; set; }
    public int y { get; set; }
}

struct Struct
{
    public int x { get; set; }
    public int y { get; set; }
}
