using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Square : Shape
    {
        public double SideLength { get; set; }

        public override void Accept(ShapeVisitor visitor)
        {
            visitor.VisitSquare(this);
        }
    }
}
