using System;

namespace ConsoleApp1.Methods
{
    public class Rectangle
    {
        int length;
        int breadth;
       public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public void CalculateArea()
        {
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle: " + area);
            
        }
    }
    internal class MethodReturningObject_calarea
    {
        // Method that returns a Rectangle object
        public Rectangle CreateRectangle(int length, int breadth)
        {
            return new Rectangle(length, breadth);
        }

        static void Main(string[] args)
        {
            MethodReturningObject_calarea obj = new MethodReturningObject_calarea(); //// You have an instance of the class that can create Rectangles.

            // Get Rectangle object from method
            Rectangle rect = obj.CreateRectangle(5, 3); // class Rectangle reference variable is created here , bcz the method CreateRectangle returns a Rectangle object

            // Call method on returned object
            rect.CalculateArea();
        }
    }
}
