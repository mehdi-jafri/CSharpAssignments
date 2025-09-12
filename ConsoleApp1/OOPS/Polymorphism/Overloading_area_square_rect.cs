using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS.Polymorphism
{
    public class Shape
    {
        // Area of square
        public void Area(int side)
        {
            int area = side * side;
            Console.WriteLine("Area of Square: " + area);
        }

        // Area of rectangle
        public void Area(int length, int breadth)
        {
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
    internal class Overloading_area_square_rect
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();

            // Call overloaded methods
            shape.Area(5);        // Calls square version
            shape.Area(6, 4);     // Calls rectangle version
        }

    }
}
