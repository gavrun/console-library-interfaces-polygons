using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_interfaces_polygons
{
    class Square : ConcreteRegularPolygon
    {
        //base constructor
        public Square(int length) : base(4, length)
        { }

        //each polygon has its own method
        //not forced to provide child method here
        public override double GetArea()
        {
            return SideLength * SideLength;
        }

    }
}
