using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_interfaces_polygons
{
    //abstract class
    public class Triangle : AbstractRegularPolygon
    {
        //base constructor
        public Triangle(int length) : base(4, length)
        { }

        //each polygon has its own method
        //MUST be implemented as an inherited member (compile error)
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }

    }
}
