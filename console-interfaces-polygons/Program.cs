using System;

namespace console_interfaces_polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            //using concrete class
            var square = new Square(5);
            DisplayPolygon("Square", square);

            //


            //

        }

        //additional off topic
        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            //try-catch statement 
            try
            {
                Console.WriteLine("{0} Number of Sides: {1}", polygonType, polygon.NumberOfSides);
                Console.WriteLine("{0} Side Length: {1}", polygonType, polygon.SideLength);
                Console.WriteLine("{0} Perimeter: {1}", polygonType, polygon.GetPerimeter());
                Console.WriteLine("{0} Area: {1}", polygonType, Math.Round(polygon.GetArea(), 2));
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown while trying to process {0}:\n   {1}",
                    polygonType, ex.GetType().Name);
                Console.WriteLine();
            }
        }
    }
}
