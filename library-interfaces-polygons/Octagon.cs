using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_interfaces_polygons
{
    //interface class
    public class Octagon : Object, IRegularPolygon //everything inherited from Object class anyway
    {
        //automatic properties
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        //constructor
        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        //method for all polygones is the same
        //MUST be implemented as an inherited member
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        //each polygon has its own method
        //MUST be implemented as an inherited member
        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
