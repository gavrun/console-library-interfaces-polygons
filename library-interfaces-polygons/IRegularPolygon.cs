using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_interfaces_polygons
{
    //interface class
    public interface IRegularPolygon
    {
        //declaration for properties
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        //public is default

        //declaration for methods
        double GetPerimeter();
        double GetArea();

        //no implementation code here
    }
}
