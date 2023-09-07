// UPCASTING: conversão da classe derivada para a classe base

// exemplo 1
Shape circle = new Circle(207, 75); // é um objeto do tipo 'Shape'
circle.Draw();

// exemplo 2
Circle circle1 = new(34, 89);
Shape shape1 = circle1; // a conversão aqui é implícita

Console.WriteLine(shape1 == circle1); // True


// DOWNCASTING: conversão da classe base para a classe derivada

Shape shape2 = new Circle(34, 89); // é um objeto do tipo 'Shape'
Circle circle2 = (Circle)shape2; // a conversão aqui é explícita

Console.WriteLine(shape2 == circle2); // True



Console.ReadKey();

// classes
class Shape // classe base
{
    protected int xPos, yPos;

    public Shape() { }

    public Shape(int xPos, int yPos)
    {
        this.xPos = xPos;
        this.yPos = yPos;
    }

    public virtual void Draw()
    {
        Console.WriteLine($"{this} on position: ({xPos}, {yPos})");
    }
}

class Circle : Shape // classe derivada
{
    public Circle() { }

    public Circle(int x, int y) : base (x, y) { }

    public override void Draw()
    {
        base.Draw();
    }

    public void DrawCircle()
    {
        Console.WriteLine("Draw Circle");
    }
}
