using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public abstract class Shape
    {
        public abstract void Accept(ShapeVisitor visitor);
    }
}
