// MEMBROS ESTÁTICOS (CAMPOS E PROPRIEDADES)

ClasseA objetoA = new ClasseA();

objetoA.x = 1; // atribuindo valor à instância da classe
ClasseA.y = 2; // atribuindo valor diretamente ao membro da classe

Console.WriteLine(objetoA.x);
Console.WriteLine(ClasseA.y);

class ClasseA
{
    public int x;
    public static int y;
}
