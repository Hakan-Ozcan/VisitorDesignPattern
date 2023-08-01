using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.Abstract;

namespace VisitorDesignPattern.Entities
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
