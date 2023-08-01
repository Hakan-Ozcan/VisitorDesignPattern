using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.Abstract;

namespace VisitorDesignPattern.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override void Accept(ShapeVisitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }
}
