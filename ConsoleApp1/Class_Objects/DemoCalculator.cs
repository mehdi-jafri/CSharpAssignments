using System;

namespace ConsoleApp1.Class_Objects
{
    internal class DemoCalculator
    {
        // Method to calculate square of a number
        internal int sq(int a)
        {
            return a * a;
        }

        // Method to calculate cube of a number
        internal int cub(int a)
        {
            return a * a * a;
        }

        // Method to calculate area of rectangle
        internal int area(int h, int w)
        {
            return h * w;
        }
        static void Main()
        {
            DemoCalculator obj = new DemoCalculator();

            int number = 5;
            int height = 4;
            int width = 6;

            Console.WriteLine("Square of {0} is {1}", number, obj.sq(number));
            Console.WriteLine("Cube of {0} is {1}", number, obj.cub(number));
            Console.WriteLine("Area of rectangle ({0} x {1}) is {2}", height, width, obj.area(height, width));

            Console.ReadLine(); // To keep the console window open
        }
    }
}
