using System;

namespace ConsoleApp1.OOPS
{
    interface IVehicle
    {
        void Start();   // Method without implementation
        void Stop();    // Method without implementation
    }

    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car has started.");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped.");
        }
    }

    // Step 3: Implement the interface in another class
    class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike has started.");
        }

        public void Stop()
        {
            Console.WriteLine("Bike has stopped.");
        }
    }

    internal class InterfaceDemo
    {
        static void Main(string[] args)
        {
            IVehicle car = new Car();   // Interface reference to Car
            IVehicle bike = new Bike(); // Interface reference to Bike

            Console.WriteLine("---- Car Actions ----");
            car.Start();
            car.Stop();

            Console.WriteLine("\n---- Bike Actions ----");
            bike.Start();
            bike.Stop();
        }
    }
}
