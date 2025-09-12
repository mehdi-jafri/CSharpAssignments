using System;

namespace ConsoleApp1.OOPS.Polymorphism
{
    public class Shapes  // Base class demonstrating method overloading
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

        // Virtual method to be overridden
        public virtual void Area()
        {
            Console.WriteLine("Base class Area method.");
        }
    }
  
    public class Circle : Shapes   // Derived class overriding Area() for circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void Area()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }
    }

    internal class Overloading_Overidding_area_square_rect_Circle
    {
        static void Main(string[] args)
        {
            // Demonstrate method overloading
            Shapes shape = new Shapes();
            shape.Area(5);       // Square
            shape.Area(6, 4);    // Rectangle

            // Demonstrate method overriding
            Shapes circle = new Circle(3.5);  // Polymorphism
            circle.Area();
        }

    }
}
