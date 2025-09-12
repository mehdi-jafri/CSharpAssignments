using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS.Polymorphism
{
    internal class Overloading
    {
        public void multiply(int a, int b , int c)
        {
            Console.WriteLine("Multiplication of three integers: " + (a * b * c));
        }

        public void multiply(double a, double b)
        {
            Console.WriteLine("Multiplication of two doubles: " + (a * b));
        }
        public void multiply(float a, float b)
        {
            Console.WriteLine("Multiplication of two floats: " + (a * b));
        }

        static void Main(string[] args)
        {
            Overloading overloading = new Overloading();
            overloading.multiply(5, 10, 2); // Calling the method with two integers
            overloading.multiply(5.5, 10.5); // Calling the method with two doubles
            overloading.multiply(5.5f, 10.5f); // Calling the method with two floats

        }
    }
}
