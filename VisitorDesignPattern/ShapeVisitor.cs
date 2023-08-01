using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public abstract class ShapeVisitor
    {
        public abstract void VisitCircle(Circle circle);
        public abstract void VisitSquare(Square square);
    }
}
