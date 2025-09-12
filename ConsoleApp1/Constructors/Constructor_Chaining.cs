using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructors
{
    class Vehicle2
    {
        public int Wheels;

        public Vehicle2()
        {
            Wheels = 4;
            Console.WriteLine("Vehicle default constructor");
        }

        public Vehicle2(int wheels)
        {
            Wheels = wheels;
            Console.WriteLine("Vehicle parameterized constructor");
        }
    }

    class Car3 : Vehicle2
    {
        public string Brand;

        // Calls Vehicle(int wheels) constructor using base
        public Car3(string brand) : base(4)
        {
            Brand = brand;
            Console.WriteLine("Car constructor with brand");
        }

        // Constructor chaining within Car class using this()
        public Car3() : this("DefaultBrand")
        {
            Console.WriteLine("Car default constructor");
        }

        public void Display()
        {
            Console.WriteLine($"Brand: {Brand}, Wheels: {Wheels}");
        }
    }
    internal class Constructor_Chaining
    {
        static void Main()
        {
            Car3 car1 = new Car3();
            car1.Display();

            Car3 car2 = new Car3("Toyota");
            car2.Display();
        }
    }
}
