using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_interfaces_polygons
{
    //concrete class
    public class ConcreteRegularPolygon
    {
        //automatic properties
        public int NumberOfSides { get; set; }
        //public int SideLength { get; set; }

        //full property
        private int sideLength;

        public int SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }

        //constructor
        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        //method for all polygones
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        //each polygon has its own method
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
