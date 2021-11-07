using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_interfaces_polygons
{
    //abstract class
    public abstract class AbstractRegularPolygon
    {
        //properties
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        //constructor
        public AbstractRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        //method for all polygones is the same
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        //abstract method
        public abstract double GetArea();

    }
}
