using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class AreaVisitor : ShapeVisitor
    {
        public override void VisitCircle(Circle circle)
        {
            double area = Math.PI * circle.Radius * circle.Radius;
            Console.WriteLine($"Circle Area: {area}");
        }

        public override void VisitSquare(Square square)
        {
            double area = square.SideLength * square.SideLength;
            Console.WriteLine($"Square Area: {area}");
        }
    }
}
