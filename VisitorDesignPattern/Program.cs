using VisitorDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>
        {
            new Circle { Radius = 5 },
            new Square { SideLength = 4 }
        };

        var areaVisitor = new AreaVisitor();
        foreach (var shape in shapes)
        {
            shape.Accept(areaVisitor);
        }
    }
}