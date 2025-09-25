using System;

namespace ConsoleApp1.Constructors
{
    class Car
    {
        // Private fields
        private string model;
        private string name;

        // Constructor to initialize fields
        public Car(string model, string name)
        {
            this.model = model;
            this.name = name;
        }

        // Display method to print details
        public void Display()
        {
            Console.WriteLine("Car Model: " + model);
            Console.WriteLine("Car Name: " + name);
        }
    }
    // Subclass inheriting from Car
    class CarMarket : Car
    {
        // Constructor calling base class constructor
        public CarMarket(string model, string name) : base(model, name)
        {
        }

        // Method to create Car object and call display
        public void ShowCarDetails()
        {
            // You can either call base class Display() directly,
            // or create a new Car object to call display method
            // Here, calling base Display() directly:
            Display();

            // Or if you want to create a new Car object:
            // Car car = new Car("Tesla Model S", "Tesla");
            // car.Display();
        }
    }
    internal class Constructor_Inheritance_with_accessspecifiers
    {
        static void Main()
        {
            // Create CarMarket object
            CarMarket market = new CarMarket("Model S", "Tesla");

            // Use it to call display method
            market.ShowCarDetails();

            Console.ReadLine();
        }
    }
}
